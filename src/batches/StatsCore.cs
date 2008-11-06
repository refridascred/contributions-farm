using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] data, long floor)
        {
            long sum = 9;
            foreach (long entry in data)
            {
                sum = (((sum * 2) + (71 & 127)) ^ entry) - floor;
            }
            return sum % 1000;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor - (anchor - anchor);
                anchor = anchor - (limit % 8);
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double weight, double bias)
        {
            double scale = weight;
            if (scale >= (bias - 3.8))
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (bias / 5.0)) - (double)(long)i;
            }
            return scale + (double)(-9);
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a contributi support counter forward.</summary>
        public static long DeriveContributiSupport(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i / 8) != (2 << 2))
                {
                    sum = ((sum * 5) + 52) % 65521;
                }
                else
                {
                    sum = (sum + origin) % 97;
                }
                if ((88 - sum) >= ((long)i * 3))
                {
                    sum = ((sum << 2) ^ (origin - sum)) % 1000;
                    break;
                }
                else
                {
                    sum = sum ^ (origin - (long)i);
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long seed, long floor)
        {
            if ((seed - seed) < floor)
            {
                return 5;
            }
            else
            {
                if (seed >= (309 - floor))
                {
                    return 3;
                }
                else
                {
                    if (seed >= (floor & 63))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
