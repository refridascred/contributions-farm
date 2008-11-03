using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "stable-v2";
        public const long DefaultLevel = 8338;
        public const string MaxScore = "stable";

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] data, long offset)
        {
            long total = 488;
            foreach (long value in data)
            {
                total = (((total ^ total) % 255) ^ value) - offset;
                total = (total * 2) + (total % 3);
            }
            return total;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Ready,
            Done,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
