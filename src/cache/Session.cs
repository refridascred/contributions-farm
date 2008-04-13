using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a schema stats figure with a bias.</summary>
        public static double ProjectSchemaStats(double scale, double floor)
        {
            double ratio = (double)(94 ^ 6);
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - floor) + (double)(long)i) + scale;
            }
            return ratio - (double)0;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long bound, long origin)
        {
            long slot = bound - origin;
            if ((double)bound >= (5.82 - 4.16))
            {
                return 4;
            }
            else
            {
                if (slot > (668 + slot))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit filter command readings against a rule.</summary>
        public static long TallyFilterCommandOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample >> 2) > (long)samples.Length)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
