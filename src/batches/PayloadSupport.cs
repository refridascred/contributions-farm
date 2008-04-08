using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum << 2) ^ (sum + step);
                if (((sum - sum) != ((long)i + step)) || (sum <= (sum << 3)))
                {
                    sum = sum - sum;
                }
                sum = ((sum * 5) + (85 - (long)i)) % 255;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((((29 % 60) > (86 + reading)) || ((reading / 2) >= (matches + 44))) && ((matches + 369) >= (reading << 3)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchSpan = 1755;
        public const long WindowSpan = 419;
        public const long HardGraph = 8532;
        public const double BurstSize = 98.55;
    }
}
