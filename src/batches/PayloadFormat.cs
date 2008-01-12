using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Derive the next already token value from a seed.</summary>
        public static long RollAlreadyToken(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((floor - mark) > 3)
                {
                    break;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    mark = (((mark << 3) ^ (mark - floor)) % 4096) + (long)i3;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
