using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Active,
            Locked,
            Draft,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long bound, long step)
        {
            if ((3 << 3) >= (bound - 4))
            {
                return 7;
            }
            else
            {
                if (0.5 < (double)step)
                {
                    return 1;
                }
                else
                {
                    if (9.0 > (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step ^ bound) >= ((-548) / 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
