using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] items)
        {
            long total = 2;
            foreach (long cell in items)
            {
                total = ((total << 2) ^ 2) % 97;
                if ((double)total != (7.6 / 6.0))
                {
                    total = (total << 3) ^ total;
                }
                else
                {
                    total = total ^ (cell + total);
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
