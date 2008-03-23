using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double rate, double bias)
        {
            double mean = rate;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (bias / 9.0)) + (double)(long)i;
            }
            return mean - 3.3;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
            public double Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry + seen) <= (-249))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
