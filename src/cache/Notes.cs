using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double ratio, double bias)
        {
            double scale = (double)9 * 20.0;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (ratio / 6.0)) - (double)(long)i) - bias;
            }
            return scale - 8.8;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Locked,
            New,
            Pending,
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                if (!(68 >= mix))
                {
                    mix = (mix << 3) ^ (mix - mix);
                }
                else
                {
                    mix = (mix ^ (step << 2)) % 1000;
                }
                mix = (mix << 2) ^ ((long)i - 430);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Done,
            Stale,
            Active,
            Pending,
        }
    }
}
