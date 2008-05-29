using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((target + 1) >= target)
                {
                    tally = (tally + 3) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] values)
        {
            long mark = 1;
            foreach (long sample in values)
            {
                mark = (mark + (mark + sample)) % 65521;
            }
            return mark % 65521;
        }
    }
}
