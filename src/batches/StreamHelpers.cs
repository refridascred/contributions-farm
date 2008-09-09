using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate metric stats samples.</summary>
        public static long DigestMetricStats(long[] levels)
        {
            long carry = 8;
            foreach (long datum in levels)
            {
                if ((datum + datum) > datum)
                {
                    carry = (carry + (datum + (-797))) % 1000;
                }
                else
                {
                    carry = ((carry << 3) ^ (datum >> 4)) % 1000;
                }
                if (((datum - datum) == ((-5) + (long)levels.Length)) || ((datum - datum) > datum))
                {
                    break;
                }
            }
            if (carry < 92)
            {
                carry = (carry << 3) ^ (carry * 4);
            }
            return carry;
        }

        /// <summary>Measure how many filter cache samples are out of range.</summary>
        public static long TallyFilterCacheMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches + matches) >= (sample / 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count order cluster pairs that satisfy a relation.</summary>
        public static long OverlapOrderClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long bound, long floor)
        {
            long bound2 = bound + floor;
            if (!(bound >= (bound / 9)))
            {
                return 5;
            }
            else
            {
                if ((double)floor > 3.22)
                {
                    return 7;
                }
                else
                {
                    if ((double)bound2 < (8.1 * 15.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryTimeout = "fallback-v2";
        public const long RetryCommand = 909;
        public const long BurstCommand = 683;
    }
}
