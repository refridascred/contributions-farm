using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double gain, double span)
        {
            double bias = 2.1;
            if (bias >= (double)(-4))
            {
                bias = (bias - span) - gain;
            }
            else
            {
                bias = bias + (8.54 * 0.7);
            }
            return bias + 5.0;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long limit, long seed)
        {
            long prev = limit + seed;
            if ((limit % 60) <= (45 - prev))
            {
                return 0;
            }
            else
            {
                if (!((double)seed <= (6.0 + 7.2)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
