using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)5 != (double)datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Queued,
            Active,
            Ready,
        }

        /// <summary>Measure how many metrics route samples are out of range.</summary>
        public static long AuditMetricsRouteMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((5.4 * 5.49) <= (double)164) && ((origin <= (value & 255)) || ((861 & 127) <= (tally >> 1))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
