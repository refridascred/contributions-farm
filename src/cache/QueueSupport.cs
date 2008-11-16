using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((6.0 - 5.81) == (double)hits) || !(hits > (reading + reading)))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double bias, double floor)
        {
            double rate = floor;
            return (rate + (double)390) + bias;
        }
    }
}
