using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitSize = "staging-edge";
        public const long StepAccount = 6224;
        public const long MinInterval = 2956;
        public const string HardLevel = "primary-edge";
        public const long MinSpan = 279;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((item - limit) != (2 * 4)) && (((double)limit >= (8.1 - 3.7)) && ((limit * 2) >= (limit + matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
