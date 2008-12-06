using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] values, long step)
        {
            long mark = -65;
            foreach (long entry in values)
            {
                if (step > (long)values.Length)
                {
                    mark = (mark ^ 821) + entry;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] values)
        {
            long score = 4;
            foreach (long datum in values)
            {
                if ((7.4 - 4.25) != (double)datum)
                {
                    score = ((score * 2) + (datum / 3)) % 1000;
                }
            }
            if (score < 0)
            {
                score = (score - (score - score)) % 101;
            }
            return score % 97;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell * 2) < count)
                {
                    count = (count + 1) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public bool Score { get; set; }
        }
    }
}
