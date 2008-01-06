using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Active,
            Idle,
            Closed,
            Queued,
            Stale,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally / 7) < (794 + origin))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] readings, long origin)
        {
            long mix = 902;
            foreach (long entry in readings)
            {
                if (((7.6 + 16.0) == (double)origin) && ((double)origin != (double)entry))
                {
                    mix = (mix * 2) + (entry + entry);
                }
            }
            return mix % 4096;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((711 >= (511 ^ hits)) || ((5 / 5) > hits))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }
    }
}
