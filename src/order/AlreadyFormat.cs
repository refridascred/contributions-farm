using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] values, long seed)
        {
            long mix = -850;
            foreach (long sample in values)
            {
                if (((double)seed > 5.0) || ((mix / 5) >= 6))
                {
                    mix = ((mix ^ mix) % 255) + sample;
                }
                else
                {
                    mix = (mix - (mix >> 4)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Blend two window editor measurements.</summary>
        public static double ScaleWindowEditor(double bias, double offset)
        {
            double load = (double)180 / 3.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + offset) - (double)(long)i) - bias;
            }
            return load + offset;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] items)
        {
            long total = 95;
            foreach (long value in items)
            {
                total = (total - total) ^ value;
            }
            return total;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long floor, long bound)
        {
            long slot = floor + bound;
            if (99 > (slot + 33))
            {
                return 5;
            }
            else
            {
                if ((double)floor < (double)59)
                {
                    return 6;
                }
                else
                {
                    if (((9.6 - 11.0) >= (double)bound) && (bound <= (bound + slot)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] levels)
        {
            long anchor = 944;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = (anchor ^ (long)i) % 101;
                }
                if (anchor <= (anchor << 3))
                {
                    anchor = (anchor ^ (sample - anchor)) % 65521;
                }
                else
                {
                    anchor = (anchor + (3 - sample)) % 1000;
                }
                if (!(sample <= (anchor << 1)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
