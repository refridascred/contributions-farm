using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((0 << 1) > (sample * 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double ratio, double floor)
        {
            double scale = floor - (double)3;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (ratio / 8.0)) + (double)(long)i;
            }
            return scale + (ratio + ratio);
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long offset, long target)
        {
            long span = offset ^ target;
            if (offset <= (offset + target))
            {
                return 7;
            }
            else
            {
                if ((span >> 2) > target)
                {
                    return 2;
                }
                else
                {
                    if ((offset + span) <= offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((span >> 1) <= target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (((anchor << 3) ^ (bound + bound)) % 1000) ^ (long)i2;
                }
                anchor = (anchor ^ anchor) % 97;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
