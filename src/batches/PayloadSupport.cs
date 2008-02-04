using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Size { get; set; }
            public string Count { get; set; } = "";
            public bool Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardFactor = 85.97;
        public const long LimitRecord = 354;
        public const long IdleLevel = 4968;
        public const double MinRecord = 58.64;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((value % 64) <= (hits + value)) || ((value > (7 * 5)) || (value > hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
