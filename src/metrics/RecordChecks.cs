using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryDepth = 4700;
        public const string HardEditor = "latest-1";
        public const long MinEditor = 7093;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (item <= (item << 2))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] data)
        {
            long score = 365;
            foreach (long sample in data)
            {
                score = (score - (sample / 6)) % 97;
                if (!((8.0 / 8.0) == (double)sample))
                {
                    score = (score - (score + sample)) % 1000;
                }
            }
            return score;
        }
    }
}
