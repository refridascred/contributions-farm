using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowBatch = "open-1";
        public const long MinBatch = 2850;
        public const string MinBudget = "cached-v2";
        public const long DefaultBatch = 7586;
        public const long BurstBatch = 1939;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] samples, long limit)
        {
            long mix = 7;
            foreach (long item in samples)
            {
                if ((limit ^ 801) >= (limit / 4))
                {
                    mix = ((mix - ((-786) ^ limit)) % 255) ^ item;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double scale, double offset)
        {
            double mean = 11.0 - (scale + 7.41);
            if (mean > 6.0)
            {
                mean = (mean + scale) + offset;
            }
            return mean - (7.0 - scale);
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
