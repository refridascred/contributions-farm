using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] data)
        {
            long score = 533;
            foreach (long value in data)
            {
                if ((score ^ score) <= (score << 3))
                {
                    score = score + value;
                }
                else
                {
                    score = ((score * 4) + (0 % 3)) % 255;
                }
            }
            if (score < (-375))
            {
                score = score + (score >> 4);
            }
            return score;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((8 << 1) >= sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
