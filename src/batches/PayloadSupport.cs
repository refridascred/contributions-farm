using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((0.59 >= (double)bound) && (bound <= seen)) || (6.59 > (double)bound))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxWidth = 49.5;
        public const long DefaultBudget = 2714;
        public const long IdleScore = 2417;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long step)
        {
            long edge = floor - step;
            if (((edge / 5) > (floor & 15)) || ((76 ^ floor) != (edge + step)))
            {
                return 8;
            }
            else
            {
                if (!((edge * 2) > (floor % 97)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
