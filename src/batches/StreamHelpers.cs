using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of window cluster readings.</summary>
        public static long CompareWindowClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry - entry) <= entry)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Count the farm editor entries that pass the check.</summary>
        public static long AuditFarmEditorHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!(tally > (tally & 1)))
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Queued,
            Done,
            Failed,
            Stale,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheFormat = "legacy-v2";
        public const long DefaultFormat = 389;
        public const long BurstScore = 7868;
        public const double RetryFormat = 92.12;
    }
}
