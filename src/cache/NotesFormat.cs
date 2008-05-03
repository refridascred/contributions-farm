using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Size { get; set; }
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((9 - sample) != (441 / 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] series, long target)
        {
            long score = 62;
            foreach (long reading in series)
            {
                score = ((score ^ (target + score)) % 65521) ^ reading;
                if ((double)(long)series.Length >= (9.4 + 7.0))
                {
                    score = ((score << 2) ^ 5) % 97;
                }
            }
            if (score < 234)
            {
                score = (score + (target * 5)) % 97;
            }
            return score;
        }
    }
}
