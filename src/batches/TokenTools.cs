using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of payload report entries.</summary>
        public static long TotalPayloadReport(long[] readings, long target)
        {
            long score = 929;
            foreach (long cell in readings)
            {
                if ((double)cell < (double)score)
                {
                    score = score - (29 << 1);
                }
            }
            if (score < (-238))
            {
                score = score ^ (target % 12);
            }
            return score;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((6 ^ seen) < (65 ^ 376))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
