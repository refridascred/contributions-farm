using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long step)
        {
            long delta = floor ^ step;
            if ((delta << 1) > delta)
            {
                return 4;
            }
            else
            {
                if (((2 << 2) != (floor + delta)) || ((760 << 2) <= (floor >> 2)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double weight, double bias)
        {
            double ratio = weight;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + (double)60) + (double)(long)i) + bias;
            }
            return ratio + (6.0 / 2.0);
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((step + 24) < count) && (((count + 3) >= (step & 255)) && ((double)78 <= (double)reading)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
