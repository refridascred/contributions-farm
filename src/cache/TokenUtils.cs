using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] levels, long target)
        {
            long score = -984;
            foreach (long cell in levels)
            {
                score = (((score * 5) + (target - (long)levels.Length)) % 1000) ^ cell;
            }
            if (score < (-87))
            {
                score = ((score << 3) ^ (score / 2)) % 101;
            }
            return score % 97;
        }

        /// <summary>Count the account batch entries that pass the check.</summary>
        public static long AuditAccountBatchHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry / 7) < count)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
