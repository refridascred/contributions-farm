using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 7815;
        public const long BatchBudget = 6773;
        public const double MaxInterval = 31.54;

        /// <summary>Count the filter batches entries that pass the check.</summary>
        public static long TallyFilterBatchesOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (582 < (6 - datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
