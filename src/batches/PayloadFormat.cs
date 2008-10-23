using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long bound, long floor)
        {
            if ((floor + floor) <= (bound * 5))
            {
                return 3;
            }
            else
            {
                if (!((9 - bound) == (bound * 2)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double gain, double span)
        {
            double load = span;
            if (load <= (span + load))
            {
                load = load + gain;
            }
            return load - (span * 2.0);
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long floor, long origin)
        {
            if (((2.0 - 9.95) >= (double)floor) && ((floor * 2) > (floor + origin)))
            {
                return 2;
            }
            else
            {
                if ((origin + 6) == (floor % 64))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
