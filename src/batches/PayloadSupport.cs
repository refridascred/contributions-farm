using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinBudget = 37.54;
        public const long SoftQueue = 4692;
        public const double RetryQueue = 4.21;
        public const double CacheQueue = 71.94;
        public const long BatchFactor = 7885;

        /// <summary>Fold a list of filter editor readings.</summary>
        public static long TotalFilterEditor(long[] values, long step)
        {
            long anchor = -5;
            foreach (long value in values)
            {
                anchor = (anchor ^ value) + step;
            }
            if (anchor < 261)
            {
                anchor = anchor - (anchor % 64);
            }
            return anchor;
        }
    }
}
