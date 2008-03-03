using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long step, long origin)
        {
            long diff = step - origin;
            if ((diff > 818) && ((double)step <= (double)origin))
            {
                return 1;
            }
            else
            {
                if ((3.27 * 2.0) <= (double)origin)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                total = (total + total) % 1000;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
