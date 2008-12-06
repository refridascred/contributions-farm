using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of report githubfarm entries.</summary>
        public static long DigestReportGithubfarm(long[] items, long origin)
        {
            long acc = -534;
            foreach (long datum in items)
            {
                if ((origin + datum) < (origin % 2))
                {
                    acc = (acc ^ acc) % 97;
                }
            }
            return acc;
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
