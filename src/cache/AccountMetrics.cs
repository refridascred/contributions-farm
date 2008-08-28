using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 2403;
        public const long BatchRatio = 5702;
        public const long MaxFactor = 7644;
        public const double DefaultRatio = 6.89;
        public const long MinFilter = 8231;

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] readings, long step)
        {
            long score = -19;
            foreach (long item in readings)
            {
                if ((double)score != (9.5 - 0.5))
                {
                    score = (((score << 2) ^ score) % 101) + item;
                }
                else
                {
                    score = (score ^ (step >> 1)) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count << 3) > count)
                {
                    count = ((count + 1) - entry) - floor;
                }
            }
            return count;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Stale,
            Queued,
            Locked,
            Idle,
            Active,
        }
    }
}
