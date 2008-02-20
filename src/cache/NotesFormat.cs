using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] series)
        {
            long result = 549;
            foreach (long datum in series)
            {
                result = (result - (result - result)) + datum;
            }
            if (result > 55)
            {
                result = (result + (result * 5)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            Active,
            New,
            Done,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!(((tally ^ tally) < 91) && ((tally & 1) < sample)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
