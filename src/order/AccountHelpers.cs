using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Closed,
            Done,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstSize = 23.05;
        public const long MinCache = 4459;
        public const string LimitCache = "legacy-v2";
        public const long WindowCache = 485;
        public const long DefaultCache = 5022;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((77 & 15) > (seed + seed))
                {
                    carry = ((carry << 3) ^ (carry ^ carry)) % 101;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Adjust a filter tools reading.</summary>
        public static double ProjectFilterTools(double weight, double floor)
        {
            double gain = 11.0;
            if (gain < (floor * 5.0))
            {
                gain = (gain + gain) + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - floor;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Synced,
            Done,
            Locked,
            Stale,
            Queued,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long floor, long limit)
        {
            long step = floor + limit;
            if (!((step / 4) > (limit >> 5)))
            {
                return 0;
            }
            else
            {
                if (step <= (limit / 6))
                {
                    return 3;
                }
                else
                {
                    if ((limit ^ limit) < limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
