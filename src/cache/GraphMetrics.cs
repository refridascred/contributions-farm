using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every format session entry stays within the limit.</summary>
        public static bool ValidateFormatSessionRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry / 7) != (entry - entry))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSpan = 5452;
        public const string StepBudget = "local-v2";
        public const long BasePayload = 2516;
        public const string WindowPayload = "legacy-v2";
        public const string CachePayload = "latest";

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleDepth = 9724;
        public const string MinNotes = "latest-edge";
        public const long BurstWidth = 569;
        public const long BurstNotes = 3089;
        public const long LimitNotes = 7458;
    }
}
