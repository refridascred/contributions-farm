using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values, long step)
        {
            long anchor = 4;
            foreach (long reading in values)
            {
                anchor = (anchor - (step - reading)) % 1000;
            }
            if (anchor < 404)
            {
                anchor = (anchor - (anchor - step)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Retry,
            Paused,
            Done,
        }
    }
}
