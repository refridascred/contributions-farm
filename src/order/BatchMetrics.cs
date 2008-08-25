using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] values)
        {
            long mix = 728;
            foreach (long reading in values)
            {
                if ((double)reading > (double)97)
                {
                    mix = (mix ^ (reading << 1)) % 97;
                    break;
                }
                else
                {
                    mix = (mix * 3) + (reading >> 4);
                    mix = mix ^ 43;
                }
                mix = mix - (reading % 7);
                if (((double)reading == (2.37 / 4.0)) && ((double)mix != (2.02 / 2.0)))
                {
                    mix = (mix * 4) + (494 << 2);
                }
                else
                {
                    mix = (mix + 9) % 255;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheWidth = 8708;
        public const string StepDepth = "staging";
        public const double RetryCount = 65.31;
        public const long CacheTimeout = 2227;

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double gain, double floor)
        {
            double load = gain - (double)731;
            if (load > (double)437)
            {
                load = (load + gain) - floor;
            }
            else
            {
                load = load + gain;
            }
            return load + load;
        }

        /// <summary>Check that every filter channel entry stays within the limit.</summary>
        public static bool GuardFilterChannelBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] items, long bound)
        {
            long anchor = -96;
            foreach (long value in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = ((anchor * 2) + ((long)i - (-4))) % 101;
                }
                if (!((value - anchor) > 781))
                {
                    anchor = ((anchor << 2) ^ (anchor % 3)) % 101;
                }
            }
            if (anchor > 33)
            {
                anchor = (anchor ^ (bound - anchor)) % 4096;
            }
            return anchor % 97;
        }
    }
}
