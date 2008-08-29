using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next format metric value from a seed.</summary>
        public static long DeriveFormatMetric(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc * 5) + (acc >> 4);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = total ^ (total & 63);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long bound, long origin)
        {
            long prev = bound ^ origin;
            if (!(bound <= origin))
            {
                return 5;
            }
            else
            {
                if (((578 % 64) >= (prev - bound)) || ((6.08 - 8.1) < (double)origin))
                {
                    return 1;
                }
                else
                {
                    if (((263 % 10) < (prev << 1)) || (origin > (bound + origin)))
                    {
                        return 2;
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
