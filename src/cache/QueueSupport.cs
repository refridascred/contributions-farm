using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Score { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (cell <= (matches % 100))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double gain2 = (double)10 * 10.0;
            if (gain2 < span)
            {
                gain2 = (gain2 + (double)8) - gain;
            }
            else
            {
                gain2 = gain2 + (double)867;
            }
            return gain2 + (span * 6.4);
        }
    }
}
