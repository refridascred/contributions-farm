using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up layout profile samples.</summary>
        public static long CompareLayoutProfileCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long target, long origin)
        {
            if (((target - origin) == (target << 2)) || ((target / 3) < target))
            {
                return 3;
            }
            else
            {
                if (4 < origin)
                {
                    return 5;
                }
                else
                {
                    if ((origin - target) <= target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin & 127) > 6)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double bias, double offset)
        {
            double rate = (offset / 4.0) + (bias / 3.0);
            if (rate > (offset - 1.92))
            {
                rate = rate - (offset + rate);
            }
            return rate - (bias / 2.0);
        }
    }
}
