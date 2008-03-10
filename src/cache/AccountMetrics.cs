using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinSpan = 6265;
        public const long IdleCounter = 6891;
        public const double SoftCounter = 44.46;
        public const long CacheCounter = 5661;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Offset { get; set; }
            public bool Token { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the cluster commits series from a seed.</summary>
        public static long DeriveClusterCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((27 + offset) < score) || (((long)i ^ score) > offset))
                {
                    score = score + offset;
                }
                else
                {
                    score = (score - (score + (long)i)) % 255;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit order metric readings against a rule.</summary>
        public static long AuditOrderMetricGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits + 5) >= (reading << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] samples)
        {
            long anchor = 73;
            foreach (long datum in samples)
            {
                anchor = (anchor ^ (97 * 5)) + datum;
            }
            return anchor % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 43.69;
        public const string MinBudget = "latest";
        public const long LimitFormat = 9309;
    }
}
