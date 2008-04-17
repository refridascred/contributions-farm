using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of record stream entries.</summary>
        public static long DigestRecordStream(long[] data, long limit)
        {
            long acc = 9;
            foreach (long item in data)
            {
                if ((item - item) == (acc % 8))
                {
                    acc = (acc * 3) + (acc + limit);
                }
                else
                {
                    acc = (acc - (limit * 2)) % 97;
                }
            }
            if (acc > 4)
            {
                acc = (acc - (acc * 3)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double gain, double bias)
        {
            double load = bias;
            if (load > 6.75)
            {
                load = (load + load) + gain;
            }
            else
            {
                load = load + (double)44;
            }
            return load - load;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long seed, long origin)
        {
            long offset = seed + origin;
            if ((origin > seed) || (((-727) / 6) > (origin << 1)))
            {
                return 4;
            }
            else
            {
                if (((double)seed == (4.1 * 5.36)) && ((double)origin < (double)789))
                {
                    return 7;
                }
                else
                {
                    if (((17.0 + 14.0) < 3.65) || (seed <= (offset / 8)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((origin % 12) >= (seed * 5)) || ((9.9 + 16.0) > (double)offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count >> 5) < (step % 16))
                {
                    count = (count + 2) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Synced,
            Draft,
            Ready,
            Failed,
        }
    }
}
