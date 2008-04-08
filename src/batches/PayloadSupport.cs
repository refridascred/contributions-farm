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

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long bound, long bound2)
        {
            long span = bound - bound2;
            if (1 > (bound2 & 1))
            {
                return 5;
            }
            else
            {
                if ((double)span != (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((span % 16) > (bound2 - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound * 2) < bound2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchSpan = 1755;
        public const long WindowSpan = 419;
        public const long HardGraph = 8532;
        public const double BurstSize = 98.55;
    }
}
