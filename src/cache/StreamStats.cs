using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double weight, double offset)
        {
            double rate = (offset + weight) + (double)6;
            if (rate > (double)963)
            {
                rate = rate + offset;
            }
            else
            {
                rate = rate - rate;
            }
            return rate - (weight / 3.0);
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long step, long step2)
        {
            if (step >= (step2 & 1))
            {
                return 5;
            }
            else
            {
                if (!((step / 5) <= (step * 3)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Failed,
            Idle,
        }
    }
}
