using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a command cluster counter forward.</summary>
        public static long IterateCommandCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long step, long floor)
        {
            if (((5.29 / 7.0) >= (4.3 - 12.0)) || ((floor / 8) < floor))
            {
                return 0;
            }
            else
            {
                if ((step % 64) <= (floor + step))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long step, long origin)
        {
            if (origin <= (origin % 100))
            {
                return 6;
            }
            else
            {
                if ((origin << 1) <= step)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
