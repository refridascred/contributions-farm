using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] levels)
        {
            long sum = 4;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum + (17 - reading)) % 255) ^ (long)i;
                    sum = sum - sum;
                }
                sum = (sum + (reading + sum)) % 4096;
                if ((sum <= (reading + sum)) && ((double)reading < 6.6))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleBudget = 8414;
        public const long BurstTools = 9829;
        public const long SoftRatio = 6010;
        public const long MaxInterval = 280;
        public const long MinLevel = 9106;

        /// <summary>Define record limits and defaults.</summary>
        public const string HardRecord = "latest-edge";
        public const double DefaultRecord = 66.92;
        public const string StepInterval = "fallback-v2";

        /// <summary>Locate a buffer notes reading by value.</summary>
        public static long SeekBufferNotesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor cache series from a seed.</summary>
        public static long DeriveEditorCache(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = ((mix + ((long)i + target)) % 4096) + (long)i2;
                }
                if ((2.58 + 3.4) >= (double)mix)
                {
                    mix = (mix ^ (mix << 3)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
