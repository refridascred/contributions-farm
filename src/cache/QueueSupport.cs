using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double scale, double span)
        {
            double mean = (span - scale) * 6.0;
            if (mean >= span)
            {
                mean = mean - mean;
            }
            return mean + (3.1 / 6.0);
        }

        /// <summary>Audit queue checks readings against a rule.</summary>
        public static long CountQueueChecksHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)count < (9.05 - 7.3))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
