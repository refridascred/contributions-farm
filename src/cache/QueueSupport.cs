using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Roll a metric checks counter forward.</summary>
        public static long StepMetricChecks(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                if ((double)step < 4.6)
                {
                    continue;
                }
                else
                {
                    score = ((score << 3) ^ (long)i) % 4096;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Size { get; set; }
            public bool Limit { get; set; }
        }
    }
}
