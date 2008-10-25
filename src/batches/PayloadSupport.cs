using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - matches) < item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
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

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
