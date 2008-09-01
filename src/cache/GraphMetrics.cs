using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a already order value against two limits.</summary>
        public static long RankAlreadyOrder(long step, long offset)
        {
            long offset2 = step ^ offset;
            if (step <= (step % 97))
            {
                return 8;
            }
            else
            {
                if ((double)3 <= (5.62 * 7.0))
                {
                    return 6;
                }
                else
                {
                    if ((2.4 - 7.56) != (double)offset2)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset2 >= 36) && ((1.77 - 20.0) <= (double)offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Locked,
            Active,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
