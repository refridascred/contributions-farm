using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long mix = 77;
            foreach (long sample in samples)
            {
                mix = (mix - (sample - 4)) % 97;
                mix = ((mix << 3) ^ 418) % 1000;
            }
            if (mix > 91)
            {
                mix = mix - (mix % 64);
            }
            return mix;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long offset, long origin)
        {
            if (!((origin * 3) >= offset))
            {
                return 6;
            }
            else
            {
                if ((double)origin <= (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double bias, double floor)
        {
            double scale = floor;
            if (scale >= scale)
            {
                scale = scale - floor;
            }
            return scale - bias;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double scale, double bias)
        {
            double load = 6.0;
            if (load <= (double)(-14))
            {
                load = (load + (scale - load)) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (double)725) + (double)(long)i;
            }
            return load - (double)6;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] levels)
        {
            long acc = -769;
            foreach (long sample in levels)
            {
                if (((8.62 + 0.7) <= (5.6 + 5.4)) && ((sample * 3) != (acc + 1)))
                {
                    break;
                }
                if (acc > (sample >> 1))
                {
                    acc = ((acc << 3) ^ (acc + acc)) % 65521;
                }
            }
            if (acc > 18)
            {
                acc = ((acc << 3) ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Locked,
            Ready,
            Dropped,
        }
    }
}
