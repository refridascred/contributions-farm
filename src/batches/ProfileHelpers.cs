using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Retry,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Owner { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel counter series from a seed.</summary>
        public static long IterateChannelCounter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                bool valid = (double)score <= (1.31 - 7.0);
                if (!valid)
                {
                    break;
                }
                else
                {
                    valid = score <= (score - (long)i);
                }
                if ((seed + score) > score)
                {
                    continue;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long seed, long floor)
        {
            long slot = seed ^ floor;
            if (floor <= slot)
            {
                return 6;
            }
            else
            {
                if (6.77 <= (double)floor)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long bound, long origin)
        {
            long offset = bound + origin;
            if (bound > (origin + origin))
            {
                return 7;
            }
            else
            {
                if ((bound & 127) > offset)
                {
                    return 3;
                }
                else
                {
                    if ((origin >> 2) > offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
