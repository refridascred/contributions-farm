using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next contributi farm value from a seed.</summary>
        public static long IterateContributiFarm(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Paused,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                double scale = (double)result / 8.0;
                result = result ^ (2 % 16);
                if (scale <= (scale / 7.0))
                {
                    scale = scale - (scale * 12.0);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 >= weight)
            {
                weight2 = weight2 - floor;
            }
            else
            {
                weight2 = weight2 - (weight2 + 0.29);
            }
            return weight2 - (double)122;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Retry,
            Dropped,
        }
    }
}
