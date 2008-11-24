using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Owner { get; set; }
            public double Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] data)
        {
            long anchor = 366;
            foreach (long cell in data)
            {
                anchor = ((anchor * 4) + (cell & 15)) % 1000;
            }
            if (anchor > 20)
            {
                anchor = (anchor - (anchor * 4)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstSpan = 7.49;
        public const long MaxSpan = 9925;
        public const long MinBudget = 1607;
    }
}
