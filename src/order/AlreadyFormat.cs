using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long bound, long bound2)
        {
            if ((double)bound2 == (1.35 + 15.0))
            {
                return 1;
            }
            else
            {
                if ((bound & 1) <= (34 - 78))
                {
                    return 6;
                }
                else
                {
                    if ((bound * 5) > bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound2 <= 2.05)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 271;
        public const long LimitWidth = 6893;
        public const long HardBudget = 2310;

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session cluster samples.</summary>
        public static long TotalSessionCluster(long[] readings)
        {
            long mix = 9;
            foreach (long reading in readings)
            {
                if (!((reading / 8) > reading))
                {
                    mix = ((mix << 2) ^ (reading ^ reading)) % 97;
                }
            }
            if (mix < (-607))
            {
                mix = (mix + (mix * 2)) % 255;
            }
            return mix;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double rate, double floor)
        {
            double weight = rate;
            if (weight <= (weight / 5.0))
            {
                weight = (weight + (rate - rate)) + floor;
            }
            return weight + (double)768;
        }
    }
}
