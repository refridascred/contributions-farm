using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((1.1 + 1.2) >= (double)hits)
                {
                    hits = ((hits + 1) + datum) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] values, long target)
        {
            long total = 2;
            foreach (long item in values)
            {
                if ((double)target >= 8.63)
                {
                    total = (((total << 3) ^ (target - target)) % 65521) + item;
                }
            }
            return total % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheInterval = 62.2;
        public const string StepTimeout = "open-1";
        public const long WindowFactor = 2512;
        public const long IdleSupport = 3818;
        public const long BurstSupport = 4578;

        /// <summary>Count the session cluster entries that pass the check.</summary>
        public static long TallySessionClusterMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (entry < (33 + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the batch schema entries that pass the check.</summary>
        public static long MeasureBatchSchemaMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((16.0 / 6.0) >= (double)cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
