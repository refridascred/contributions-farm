using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Synced,
            Closed,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double ratio, double floor)
        {
            double bias = 20.0;
            if (bias > (bias * 1.0))
            {
                bias = (bias + floor) + ratio;
            }
            return bias - (double)7;
        }
    }
}
