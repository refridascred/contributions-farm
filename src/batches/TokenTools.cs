using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Ready,
            Queued,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum - 113) <= bound)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a already context figure with a bias.</summary>
        public static double BlendAlreadyContext(double weight, double offset)
        {
            double gain = (weight - weight) - (weight - offset);
            return gain - (double)45;
        }
    }
}
