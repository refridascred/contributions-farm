using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            Closed,
            New,
            Active,
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches + 1) > (matches / 4))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Offset { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long seed, long bound)
        {
            if ((bound * 5) <= (bound + seed))
            {
                return 0;
            }
            else
            {
                if ((35 + seed) >= (seed << 2))
                {
                    return 7;
                }
                else
                {
                    if ((12 << 1) < bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
