using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up cluster account samples.</summary>
        public static long OverlapClusterAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] levels, long target)
        {
            long total = 6;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = (((total * 4) + (total ^ (long)i)) % 101) - entry;
                    total = ((total << 2) ^ target) % 65521;
                }
                total = (total ^ 539) % 97;
            }
            return total;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Queued,
            Failed,
            Locked,
            New,
            Ready,
        }

        /// <summary>Classify a entry format pair into a bucket.</summary>
        public static long SortEntryFormat(long floor, long origin)
        {
            if (floor > 36)
            {
                return 7;
            }
            else
            {
                if ((floor + floor) > (505 + 2))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
