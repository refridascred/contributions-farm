using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinCluster = 85.13;
        public const double MinBudget = 83.58;
        public const double BatchCluster = 7.14;
        public const long BurstCluster = 5816;
        public const string WindowSize = "local";

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Roll a format profile counter forward.</summary>
        public static long StepFormatProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 16; i++)
            {
                total = total + (total << 1);
                if ((double)(long)i < (double)seed)
                {
                    total = total - ((long)i ^ seed);
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
