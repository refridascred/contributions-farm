using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many session payload samples are out of range.</summary>
        public static long TallySessionPayloadMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)floor >= 3.98)
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Label { get; set; }
            public double Owner { get; set; }
            public double Token { get; set; }
        }
    }
}
