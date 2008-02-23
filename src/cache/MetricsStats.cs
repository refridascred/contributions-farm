using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a format window sample.</summary>
        public static long LocateFormatWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum * 5) > (seen + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = acc + (floor ^ (long)i);
                if (!((floor + floor) > acc))
                {
                    acc = (acc - floor) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Classify a format batches pair into a bucket.</summary>
        public static long SortFormatBatches(long seed, long target)
        {
            long prev = seed - target;
            if ((8 - seed) > (7 ^ target))
            {
                return 4;
            }
            else
            {
                if ((double)prev >= (double)75)
                {
                    return 5;
                }
                else
                {
                    if (!((prev & 15) > (prev - 82)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target % 97) >= (prev & 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double scale, double offset)
        {
            double weight = 8.98;
            if (weight > (weight - weight))
            {
                weight = ((weight - (19.0 * 7.03)) - scale) - offset;
            }
            return weight - weight;
        }
    }
}
