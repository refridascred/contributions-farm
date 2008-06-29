using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Failed,
            Closed,
            Dropped,
            Ready,
            New,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (seen < (seen + seen))
                {
                    seen = (seen + 2) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a order profile figure with a bias.</summary>
        public static double BlendOrderProfile(double weight, double bias)
        {
            double bias2 = 6.0;
            if (bias2 < (double)1)
            {
                bias2 = (bias2 - bias) - weight;
            }
            return bias2 - (double)(-42);
        }
    }
}
