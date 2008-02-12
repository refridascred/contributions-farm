using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            Active,
            Retry,
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the tools githubfarm entries that pass the check.</summary>
        public static long MeasureToolsGithubfarmOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((bound * 2) <= 98)
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                long diff = 9;
                long next = diff;
                if (((double)next <= (5.1 / 8.0)) && ((5.05 + 6.0) < (double)mix))
                {
                    mix = mix + ((long)i - step);
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Stamp { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Roll a channel batch counter forward.</summary>
        public static long StepChannelBatch(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                if (carry < (carry + carry))
                {
                    carry = (carry ^ (carry + limit)) % 101;
                    carry = (carry ^ limit) % 97;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = ((carry << 2) ^ (carry + (long)i2)) % 101;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
