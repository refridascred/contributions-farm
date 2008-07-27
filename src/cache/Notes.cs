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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 7626;
        public const string LimitBuffer = "fallback-edge";
        public const long LimitInterval = 4989;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
