using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry + entry) < (step ^ entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long origin, long origin2)
        {
            long gap = origin + origin2;
            if ((gap * 2) >= (469 + origin))
            {
                return 1;
            }
            else
            {
                if (gap >= origin)
                {
                    return 3;
                }
                else
                {
                    if ((origin >> 1) != (origin2 + origin2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)gap < (3.0 / 3.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double rate, double floor)
        {
            double drift = (floor * 1.0) + (6.0 - rate);
            if (drift > (double)(-609))
            {
                drift = drift - (drift * 0.8);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (drift + floor)) + (double)(long)i;
            }
            return drift + 2.0;
        }
    }
}
