using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long floor)
        {
            long gap = offset ^ floor;
            if ((gap - floor) >= (813 * 4))
            {
                return 6;
            }
            else
            {
                if ((floor - offset) <= (floor + gap))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Offset { get; set; }
            public double Owner { get; set; }
            public bool Weight { get; set; }
        }
    }
}
