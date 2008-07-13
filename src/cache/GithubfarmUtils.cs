using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] readings)
        {
            long score = -911;
            foreach (long value in readings)
            {
                score = score - (score - value);
            }
            if (score < 92)
            {
                score = (score + (score % 60)) % 255;
            }
            return score % 97;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((double)hits == (8.1 - 1.6)))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Token { get; set; }
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count the token batch entries that pass the check.</summary>
        public static long MeasureTokenBatchGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)sample < (double)matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
