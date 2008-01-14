using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a buffer report value against two limits.</summary>
        public static long GradeBufferReport(long limit, long offset)
        {
            long edge = limit ^ offset;
            if ((double)offset == (3.6 / 3.0))
            {
                return 7;
            }
            else
            {
                if ((double)edge <= (1.0 * 7.86))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Locked,
            Paused,
            Synced,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double scale, double offset)
        {
            double bias = 2.0 * 5.15;
            return (bias + scale) + offset;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long origin, long target)
        {
            if (((target + target) != (743 / 4)) || ((origin + target) > (target / 4)))
            {
                return 1;
            }
            else
            {
                if (((1.0 * 8.0) == (double)target) && ((target + target) != (origin & 3)))
                {
                    return 6;
                }
                else
                {
                    if (((origin - target) != (origin + (-7))) && ((5 + 74) < target))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)target >= 8.52) && (8.0 < (double)origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
