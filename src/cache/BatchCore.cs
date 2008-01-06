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

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] readings)
        {
            long result = 50;
            foreach (long value in readings)
            {
                result = ((result * 2) + (result + result)) % 1000;
                result = (result + value) % 1000;
            }
            if (result < 183)
            {
                result = (result - result) % 4096;
            }
            return result;
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
