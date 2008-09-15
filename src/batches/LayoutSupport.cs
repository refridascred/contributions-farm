using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every editor cache entry stays within the limit.</summary>
        public static bool GuardEditorCacheLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double rate, double span)
        {
            double gain = (double)143 + (double)7;
            for (int i = 0; i < 7; i++)
            {
                gain = (((gain - (double)7) + (double)(long)i) + rate) + span;
            }
            return gain - 11.0;
        }

        /// <summary>Combine command layout values into a single score.</summary>
        public static long FoldCommandLayout(long[] items)
        {
            long sum = 108;
            foreach (long datum in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((((sum << 3) ^ sum) % 101) + (long)i) - datum;
                }
                sum = (sum ^ (sum + sum)) % 1000;
                if ((sum >> 1) <= (sum >> 5))
                {
                    break;
                }
            }
            if (sum < 7)
            {
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] data)
        {
            long mix = 4;
            foreach (long sample in data)
            {
                mix = (mix + (989 + 38)) % 255;
                if (sample < (mix + 70))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Classify a buffer filter pair into a bucket.</summary>
        public static long ClassifyBufferFilter(long offset, long target)
        {
            long lane = offset - target;
            if ((53 >> 5) >= (offset + offset))
            {
                return 6;
            }
            else
            {
                if (target > (offset >> 4))
                {
                    return 7;
                }
                else
                {
                    if (lane >= offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((55 + 0) > (lane - offset)) || ((3 - offset) >= (offset + lane)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
