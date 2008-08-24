using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor stats value against two limits.</summary>
        public static long GradeEditorStats(long offset, long offset2)
        {
            long lane = offset - offset2;
            if (((offset2 & 15) >= offset) || ((double)offset2 > (double)offset))
            {
                return 1;
            }
            else
            {
                if ((lane - lane) < (offset + offset2))
                {
                    return 3;
                }
                else
                {
                    if (offset >= (offset2 + lane))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset & 255) == (41 >> 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long offset, long step)
        {
            long cur = offset + step;
            if (3 <= cur)
            {
                return 1;
            }
            else
            {
                if ((double)offset > (0.6 + 1.0))
                {
                    return 3;
                }
                else
                {
                    if (((19.0 * 8.96) == (double)step) || ((2.75 - 7.9) == (double)offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double bias, double floor)
        {
            double mean = bias;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (floor * 5.22)) + (double)(long)i;
            }
            return mean + (double)782;
        }
    }
}
