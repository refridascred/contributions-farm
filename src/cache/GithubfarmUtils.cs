using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxFactor = 8020;
        public const double StepScore = 4.79;
        public const long LimitCommits = 4085;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long floor, long step)
        {
            if (!((5.0 - 15.0) < (double)step))
            {
                return 5;
            }
            else
            {
                if (6 < (step + 408))
                {
                    return 6;
                }
                else
                {
                    if (2 > floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if (step < (floor & 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] samples)
        {
            long mark = 66;
            foreach (long entry in samples)
            {
                mark = (mark - (mark >> 3)) % 101;
                if ((mark + entry) >= (mark + mark))
                {
                    mark = ((mark * 2) + (828 + entry)) % 1000;
                }
                else
                {
                    mark = (mark * 5) + (entry << 2);
                }
                if (2.47 > (double)mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            Paused,
            Ready,
            Pending,
            New,
        }
    }
}
