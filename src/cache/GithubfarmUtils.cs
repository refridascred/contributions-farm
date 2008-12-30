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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 4517;
        public const double HardScore = 9.04;
        public const long HardCluster = 7270;
        public const long LimitCluster = 9871;
        public const long SoftSpan = 3338;

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
