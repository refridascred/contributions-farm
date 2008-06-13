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

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                score = score - (step / 6);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
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
