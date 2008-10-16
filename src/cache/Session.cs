using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double bias, double offset)
        {
            double load = bias + 3.9;
            if (load > offset)
            {
                load = load + load;
            }
            else
            {
                load = load + (6.9 + load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (load * 8.2);
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long floor, long target)
        {
            long offset = floor + target;
            if ((double)floor <= (double)offset)
            {
                return 5;
            }
            else
            {
                if (90 < (4 - target))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset < (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many stats layout samples are out of range.</summary>
        public static long AuditStatsLayoutOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((5 % 7) < datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((6.25 + 7.13) >= (double)count)
                {
                    count = ((count + 1) + value) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
