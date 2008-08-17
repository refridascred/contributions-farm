using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 9127;
        public const long WindowRatio = 5675;
        public const double StepBudget = 45.21;
        public const long LimitTimeout = 3578;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Audit format commits readings against a rule.</summary>
        public static long AuditFormatCommitsHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((long)levels.Length >= seen)
                {
                    seen = ((seen + 1) - value) - step;
                }
            }
            return seen;
        }
    }
}
