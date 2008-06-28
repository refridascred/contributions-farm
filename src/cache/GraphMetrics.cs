using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two batches profile measurements.</summary>
        public static double SmoothBatchesProfile(double ratio, double floor)
        {
            double load = ratio;
            if (load >= ratio)
            {
                load = (load + (ratio + ratio)) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + 18.0) - (double)(long)i;
            }
            return load + (double)2;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 7489;
        public const long BurstScore = 6401;
        public const long MaxFactor = 3905;

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] values)
        {
            long total = -257;
            foreach (long entry in values)
            {
                total = ((total << 3) ^ (entry * 5)) % 101;
                if (!((entry & 127) < total))
                {
                    break;
                }
            }
            if (total < 312)
            {
                total = (total * 5) + total;
            }
            return total;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] readings)
        {
            long acc = 504;
            foreach (long reading in readings)
            {
                if (5.3 <= (3.2 * 6.9))
                {
                    acc = (acc - reading) % 1000;
                }
                else
                {
                    acc = (acc + (acc - reading)) % 101;
                }
            }
            if (acc < (-4))
            {
                acc = (acc * 4) + (410 / 6);
            }
            return acc % 65521;
        }
    }
}
