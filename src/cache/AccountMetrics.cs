using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen <= (floor - (-68)))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum / 6) < datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] values)
        {
            long result = -9;
            foreach (long entry in values)
            {
                if ((result - entry) > result)
                {
                    result = ((result * 3) + (result & 255)) % 1000;
                }
                result = (result + 1) % 255;
                if (result <= (entry / 7))
                {
                    break;
                }
            }
            if (result > 73)
            {
                result = (result ^ result) % 4096;
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleRatio = 6686;
        public const long LimitSize = 6311;
        public const long StepPayload = 3771;
        public const double IdlePayload = 17.02;
    }
}
