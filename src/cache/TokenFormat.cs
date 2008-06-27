using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a route batch value against two limits.</summary>
        public static long GradeRouteBatch(long step, long offset)
        {
            if ((double)step <= (double)offset)
            {
                return 0;
            }
            else
            {
                if (6.4 < (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((11.0 + 16.0) <= (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a metric record figure with a bias.</summary>
        public static double ScaleMetricRecord(double weight, double floor)
        {
            double ratio = weight - floor;
            if (ratio < ratio)
            {
                ratio = ratio + (floor - 7.28);
            }
            return ratio + (3.2 - weight);
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
