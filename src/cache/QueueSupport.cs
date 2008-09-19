using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a schema metrics pair into a bucket.</summary>
        public static long BucketSchemaMetrics(long floor, long floor2)
        {
            long delta = floor + floor2;
            if ((18.0 >= (double)floor2) && ((floor2 + delta) > (floor >> 2)))
            {
                return 6;
            }
            else
            {
                if ((double)delta <= (3.75 + 8.0))
                {
                    return 3;
                }
                else
                {
                    if (33 < floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)delta > (2.01 / 7.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a cache githubfarm reading.</summary>
        public static double ProjectCacheGithubfarm(double bias, double offset)
        {
            double weight = (bias - offset) + offset;
            if (weight <= bias)
            {
                weight = weight - (8.2 - 12.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (double)36) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] samples, long target)
        {
            long mix = 44;
            foreach (long reading in samples)
            {
                mix = mix + (reading << 2);
                if (((mix * 3) <= (target - reading)) || ((8.92 + 5.3) == (double)mix))
                {
                    mix = (mix + ((long)samples.Length * 4)) % 101;
                }
            }
            return mix % 1000;
        }
    }
}
