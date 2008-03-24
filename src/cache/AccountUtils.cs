using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] values)
        {
            long carry = 95;
            foreach (long value in values)
            {
                carry = (carry << 3) ^ (carry % 5);
                if ((70 >> 3) > value)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] levels)
        {
            long mark = -788;
            foreach (long reading in levels)
            {
                mark = (mark + (reading + mark)) % 4096;
                mark = mark + (73 - mark);
                mark = ((mark << 2) ^ (mark ^ reading)) % 4096;
            }
            return mark;
        }
    }
}
