using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Active,
            Closed,
        }

        /// <summary>Measure how many entry queue samples are out of range.</summary>
        public static long TallyEntryQueueHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum ^ matches) == (datum + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCount = "primary";
        public const string MinCount = "legacy";
        public const double MaxBudget = 36.01;
        public const long StepTimeout = 4820;
    }
}
