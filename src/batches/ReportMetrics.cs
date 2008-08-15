using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double weight, double span)
        {
            double bias = 7.6;
            if (bias >= 3.2)
            {
                bias = (bias + (bias - weight)) + span;
            }
            return bias + (double)542;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix + (floor + mix)) % 101;
                if ((floor - floor) > (9 << 2))
                {
                    mix = (mix << 3) ^ (mix * 2);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Classify a notes contributi pair into a bucket.</summary>
        public static long BucketNotesContributi(long target, long offset)
        {
            if (!((offset ^ target) >= (513 - target)))
            {
                return 2;
            }
            else
            {
                if ((2.91 + 7.79) == (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((double)target != (12.0 * 8.2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
