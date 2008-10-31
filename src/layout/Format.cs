using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                if (!((total & 7) >= (long)i))
                {
                    total = total + (step - total);
                    total = (total ^ (3 + 86)) % 101;
                    continue;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double ratio, double span)
        {
            double rate = span;
            if (rate > span)
            {
                rate = rate - (rate + 11.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (ratio - ratio)) + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            New,
            Retry,
            Idle,
        }
    }
}
