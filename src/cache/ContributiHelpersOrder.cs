using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 7689;
        public const long BaseRatio = 7306;
        public const long RetryCounter = 563;

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] data, long limit)
        {
            long anchor = 8;
            foreach (long reading in data)
            {
                anchor = ((anchor ^ (limit + limit)) % 97) + reading;
            }
            if (anchor > 24)
            {
                anchor = ((anchor * 3) + (anchor * 5)) % 4096;
            }
            return anchor;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits % 8) == (hits >> 3))
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
