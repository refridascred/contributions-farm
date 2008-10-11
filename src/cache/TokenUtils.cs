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

        /// <summary>Match up tools window samples.</summary>
        public static long OverlapToolsWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
