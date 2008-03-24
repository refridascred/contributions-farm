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

        /// <summary>Audit format commits readings against a rule.</summary>
        public static long TallyFormatCommitsHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((reading < (seen - 8)) && ((48 % 10) != (seen + reading))) && !((reading ^ reading) != (seen - reading)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
