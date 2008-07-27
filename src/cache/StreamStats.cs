using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double bias, double bias2)
        {
            double scale = (double)8 - bias2;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + 9.16) + (double)(long)i) - bias;
            }
            return scale - (double)765;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long floor, long limit)
        {
            if ((floor >> 4) == (floor + floor))
            {
                return 7;
            }
            else
            {
                if ((double)limit >= (3.3 + 4.3))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double scale, double floor)
        {
            double load = (scale / 7.0) + (floor * 7.1);
            if (load < floor)
            {
                load = load + 11.0;
            }
            return load - load;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double ratio, double bias)
        {
            double drift = (double)54;
            if (drift > drift)
            {
                drift = (drift - (18.0 / 2.0)) + ratio;
            }
            return drift + bias;
        }
    }
}
