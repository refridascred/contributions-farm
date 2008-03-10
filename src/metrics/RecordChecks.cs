using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] series, long target)
        {
            long score = 71;
            foreach (long value in series)
            {
                score = ((score ^ 758) % 255) ^ value;
            }
            if (score < 8)
            {
                score = (score - target) % 255;
            }
            return score % 97;
        }

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
