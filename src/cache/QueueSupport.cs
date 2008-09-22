using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 9280;
        public const double MinOrder = 16.44;
        public const double LimitTimeout = 49.91;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count << 1) < datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
