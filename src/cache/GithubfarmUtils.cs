using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 3232;
        public const long DefaultFarm = 1032;
        public const long MaxFarm = 8890;
        public const string HardCount = "legacy-1";

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Region { get; set; }
            public double Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Iterate the metric filter series from a seed.</summary>
        public static long RollMetricFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] values, long seed)
        {
            long state = 71;
            foreach (long reading in values)
            {
                if ((state >= (reading / 2)) && ((reading - seed) >= (reading >> 5)))
                {
                    state = (state + (0 - reading)) % 101;
                    break;
                }
                state = (state * 2) + reading;
                if (((double)state >= (8.6 * 16.0)) || ((1 + seed) == (602 & 127)))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
