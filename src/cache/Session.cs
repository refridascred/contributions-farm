using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCommand = "fallback-edge";
        public const double BurstCount = 29.43;
        public const long LimitSize = 6513;
        public const string SoftCommand = "local-1";

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((double)tally <= (double)step) && !((step & 63) >= ((-39) - step)))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] data)
        {
            long carry = 30;
            foreach (long item in data)
            {
                carry = ((carry ^ (carry + carry)) % 101) + item;
                carry = carry + (377 & 15);
            }
            return carry % 1000;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
