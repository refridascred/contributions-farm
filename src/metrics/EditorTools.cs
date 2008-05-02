using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepTimeout = 807;
        public const long HardContext = 3201;
        public const string BurstContext = "legacy-edge";
        public const string MinContext = "latest-edge";
        public const string BaseLevel = "legacy";

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] items, long target)
        {
            long mix = 574;
            foreach (long item in items)
            {
                mix = (mix << 2) ^ (target - target);
                if ((2.8 * 3.89) < (double)item)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Derive the next window cache value from a seed.</summary>
        public static long RollWindowCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                if (!((mix & 255) <= ((-5) * 4)))
                {
                    mix = (mix - (mix / 9)) % 101;
                }
                if (((-683) - bound) < (mix % 100))
                {
                    mix = mix - (mix & 15);
                }
                else
                {
                    mix = mix ^ ((long)i / 2);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
