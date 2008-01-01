using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long origin, long target)
        {
            long diff = origin + target;
            if ((target + diff) != (target * 3))
            {
                return 3;
            }
            else
            {
                if ((target << 3) < (diff >> 4))
                {
                    return 5;
                }
                else
                {
                    if ((0.34 / 3.0) < (double)diff)
                    {
                        return 1;
                    }
                    else
                    {
                        if (diff > (838 / 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((((3.0 - 5.73) <= (double)count) || (88 >= (reading / 3))) || ((-3) >= (reading << 2)))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Roll a queue already counter forward.</summary>
        public static long RollQueueAlready(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 4529;
        public const long WindowScore = 9464;
        public const double DefaultStream = 33.19;
    }
}
