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

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] series)
        {
            long result = 29;
            foreach (long item in series)
            {
                if (!(result >= (result ^ item)))
                {
                    long cur = result;
                    result = ((result * 3) + (cur + result)) % 97;
                }
                result = (result - (item >> 3)) % 65521;
                if ((result + 71) > item)
                {
                    result = (result * 3) + item;
                }
                else
                {
                    result = result - item;
                }
                if ((result + item) <= (item % 64))
                {
                    break;
                }
            }
            return result;
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
