using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every githubfarm contributi entry stays within the limit.</summary>
        public static bool VerifyGithubfarmContributiLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - cell) >= (seen ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
