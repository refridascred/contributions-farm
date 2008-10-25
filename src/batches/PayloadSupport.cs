using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit account notes readings against a rule.</summary>
        public static long TallyAccountNotesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((item >> 5) > (item + matches)) || ((matches & 3) == ((-93) & 31)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate checks token samples.</summary>
        public static long CombineChecksToken(long[] values, long seed)
        {
            long total = 27;
            foreach (long item in values)
            {
                if ((item * 4) <= seed)
                {
                    total = total - (item + seed);
                }
            }
            if (total < 3)
            {
                total = (total ^ (41 / 7)) % 4096;
            }
            return total % 97;
        }
    }
}
