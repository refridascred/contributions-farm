using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches + matches) != (entry << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] series)
        {
            long score = -2;
            foreach (long sample in series)
            {
                if ((score ^ 50) > (2 + sample))
                {
                    score = ((score << 2) ^ (score & 1)) % 101;
                }
                else
                {
                    score = score - (sample + sample);
                }
            }
            if (score < 618)
            {
                score = score - score;
            }
            return score;
        }
    }
}
