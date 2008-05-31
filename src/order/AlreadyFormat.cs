using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long floor, long step)
        {
            long slot = floor ^ step;
            if ((6.09 - 1.5) != (double)slot)
            {
                return 1;
            }
            else
            {
                if (((slot >> 1) == (step >> 5)) || ((step + step) <= floor))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardDepth = 67.4;
        public const long BaseLevel = 498;
        public const long MaxInterval = 6652;

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 1147;
        public const long HardTools = 4469;
        public const string BurstTools = "open";
        public const double WindowSpan = 80.85;

        /// <summary>Digest a series of command profile entries.</summary>
        public static long TallyCommandProfile(long[] levels, long seed)
        {
            long anchor = 8;
            foreach (long reading in levels)
            {
                if (((anchor + reading) <= ((-786) - seed)) && ((seed + seed) >= anchor))
                {
                    anchor = (anchor ^ anchor) % 255;
                }
                else
                {
                    anchor = ((anchor * 4) + (reading - seed)) % 65521;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Derive the next schema contributi value from a seed.</summary>
        public static long SeriesSchemaContributi(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix - (limit + mix)) % 255;
                if (!((20 - mix) <= mix))
                {
                    mix = mix + ((long)i & 63);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
