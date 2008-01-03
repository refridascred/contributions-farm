using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double RetryBatches = 0.62;
        public const string CacheBatches = "standard-edge";
        public const long WindowBatches = 3856;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double gain, double floor)
        {
            double rate = gain / 9.0;
            if (rate <= (double)62)
            {
                rate = (rate - (double)3) - floor;
            }
            return rate + (double)52;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell * 3) >= (cell - cell))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }
    }
}
