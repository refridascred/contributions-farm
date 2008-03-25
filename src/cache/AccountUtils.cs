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

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
