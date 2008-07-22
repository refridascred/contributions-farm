using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitBuffer = "open-v2";
        public const long DefaultBuffer = 821;
        public const long SoftLevel = 8929;
        public const long CacheInterval = 2632;

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double gain, double floor)
        {
            double ratio = (double)(4 * 4);
            if (ratio >= floor)
            {
                ratio = ratio + (floor - gain);
            }
            else
            {
                ratio = ratio - (gain / 5.0);
            }
            return ratio + (double)71;
        }

        /// <summary>Classify a graph payload pair into a bucket.</summary>
        public static long RankGraphPayload(long target, long seed)
        {
            long offset = target - seed;
            if ((target / 8) < (seed * 5))
            {
                return 1;
            }
            else
            {
                if (((offset / 5) != (seed + offset)) && ((69 + seed) <= (seed - seed)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowLevel = 7202;
        public const long HardCount = 2833;
        public const long LimitTimeout = 19;
        public const long StepWidth = 8898;
        public const long IdleMetrics = 2964;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long step, long step2)
        {
            if ((2.0 * 2.0) <= (double)step)
            {
                return 7;
            }
            else
            {
                if (step2 < (-807))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor ^ bound) % 255;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
