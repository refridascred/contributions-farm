using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long origin, long floor)
        {
            long edge = origin ^ floor;
            if (floor > (origin << 2))
            {
                return 6;
            }
            else
            {
                if ((floor & 127) <= (edge >> 4))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long offset, long step)
        {
            if (((step << 2) > (step << 1)) || ((double)offset == (3.06 + 9.7)))
            {
                return 3;
            }
            else
            {
                if ((step * 4) != (offset ^ offset))
                {
                    return 0;
                }
                else
                {
                    if (!(offset >= (step >> 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset >> 2) < (step ^ step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
