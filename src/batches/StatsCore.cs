using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardDepth = 6067;
        public const string StepInterval = "stable-edge";
        public const long DefaultEditor = 4274;
        public const string RetryEditor = "fallback-1";
        public const long WindowEditor = 9001;

        /// <summary>Accumulate filter order samples.</summary>
        public static long TotalFilterOrder(long[] samples, long floor)
        {
            long sum = 69;
            foreach (long value in samples)
            {
                sum = (sum ^ (sum - sum)) % 255;
                if ((double)sum < (double)value)
                {
                    sum = ((sum * 4) + (floor + floor)) % 255;
                }
                if (((double)floor <= 18.0) && ((sum - floor) > (floor + sum)))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Total { get; set; }
            public bool Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples, long origin)
        {
            long state = -4;
            foreach (long sample in samples)
            {
                if ((long)samples.Length != (sample << 2))
                {
                    state = (state ^ (state + state)) + origin;
                }
                else
                {
                    state = (state ^ (702 >> 1)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] data)
        {
            long sum = 3;
            foreach (long cell in data)
            {
                if ((150 + (-3)) > (cell << 3))
                {
                    sum = ((sum << 2) ^ (9 - (long)data.Length)) % 101;
                }
                else
                {
                    sum = ((sum << 2) ^ 60) % 65521;
                }
                if ((9.48 * 8.0) <= (double)cell)
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
