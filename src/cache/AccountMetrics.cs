using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)limit >= 8.94)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 >= 9.88)
            {
                gain2 = (gain2 - (1.71 + floor)) - gain;
            }
            else
            {
                gain2 = gain2 - (double)35;
            }
            return gain2 - 6.8;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long bound, long bound2)
        {
            if ((bound + bound2) <= (bound2 << 1))
            {
                return 6;
            }
            else
            {
                if (bound <= (bound2 + 8))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseEditor = "cached-v2";
        public const long MinEditor = 7090;
        public const long MaxFactor = 5957;
        public const long IdleBudget = 2521;
        public const long StepEditor = 6526;

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Total { get; set; }
            public long Size { get; set; }
        }
    }
}
