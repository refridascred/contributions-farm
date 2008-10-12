using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                mix = mix - mix;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double rate, double bias)
        {
            double ratio = rate;
            return ratio + bias;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Queued,
            Synced,
            Retry,
            Ready,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryBudget = 8714;
        public const string RetryEntry = "latest";
        public const long SoftBudget = 9490;
    }
}
