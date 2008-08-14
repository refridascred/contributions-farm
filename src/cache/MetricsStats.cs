using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            New,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitSize = 5703;
        public const string HardBatches = "legacy-1";
        public const double DefaultWidth = 94.84;

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double scale, double floor)
        {
            double bias = floor;
            if (bias < (double)988)
            {
                bias = bias + (scale * 12.0);
            }
            return bias + (double)(-641);
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data)
        {
            long mark = 0;
            foreach (long entry in data)
            {
                mark = (mark * 5) + (entry ^ 5);
            }
            if (mark < 792)
            {
                mark = (mark * 5) + mark;
            }
            return mark;
        }
    }
}
