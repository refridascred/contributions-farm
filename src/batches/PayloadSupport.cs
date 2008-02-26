using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Weight { get; set; }
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] items, long floor)
        {
            long carry = 867;
            foreach (long item in items)
            {
                carry = (((carry + (carry - 64)) % 101) ^ item) - floor;
            }
            if (carry > 5)
            {
                carry = carry + (carry >> 4);
            }
            return carry % 1000;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long origin, long origin2)
        {
            if ((5 + origin2) > (origin2 * 3))
            {
                return 2;
            }
            else
            {
                if (((origin - (-819)) > (origin + origin)) || ((0.27 - 8.7) >= (double)origin2))
                {
                    return 0;
                }
                else
                {
                    if ((1.0 - 5.0) <= (double)origin2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-790) - 39) <= (origin << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
