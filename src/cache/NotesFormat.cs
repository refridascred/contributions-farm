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

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
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
