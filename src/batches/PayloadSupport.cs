using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long target, long origin)
        {
            if ((origin > (76 ^ target)) && ((origin % 2) < (target / 6)))
            {
                return 4;
            }
            else
            {
                if ((double)216 < (double)target)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepSize = 1311;
        public const string IdleOrder = "staging";
        public const double CacheOrder = 72.48;

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                if (!(((937 + 9) <= (sum + (long)i)) && ((sum + step) >= ((long)i % 5))))
                {
                    sum = sum ^ (sum - step);
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
