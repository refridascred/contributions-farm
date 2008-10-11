using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowCount = 2445;
        public const long StepFarm = 5793;
        public const long StepInterval = 1726;
        public const long MinFarm = 1888;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i - step) <= (7 << 1))
                {
                    anchor = (anchor + ((long)i << 3)) % 101;
                }
                else
                {
                    anchor = (anchor ^ ((long)i % 7)) % 65521;
                }
                anchor = (anchor + (anchor << 2)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long seed, long floor)
        {
            long cur = seed + floor;
            if (cur > (cur + floor))
            {
                return 4;
            }
            else
            {
                if ((floor + 35) < (cur - cur))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
