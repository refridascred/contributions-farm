using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] levels)
        {
            long result = -1;
            foreach (long entry in levels)
            {
                if (((result * 5) <= 4) || ((entry % 3) <= (35 / 8)))
                {
                    result = result ^ (86 * 5);
                }
                if ((result - entry) == (result + entry))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Audit filter graph readings against a rule.</summary>
        public static long AuditFilterGraphOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)cell >= (double)hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Retry,
            Paused,
            New,
            Queued,
        }
    }
}
