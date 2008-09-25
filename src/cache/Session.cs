using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchCount = 645;
        public const string MaxWindow = "fallback-edge";
        public const long DefaultSpan = 5056;
        public const long HardDepth = 7;

        /// <summary>Count the batches batch entries that pass the check.</summary>
        public static long MeasureBatchesBatchMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry % 10) >= matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
