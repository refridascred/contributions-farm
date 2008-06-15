using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheWidth = 5154;
        public const double CacheStream = 94.77;
        public const long RetryStream = 5562;

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            Idle,
            Closed,
            Retry,
            Pending,
        }

        /// <summary>Measure how many graph route samples are out of range.</summary>
        public static long CountGraphRouteGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((((double)bound < (1.5 * 9.5)) || ((entry + entry) <= matches)) || ((entry - 1) < (69 % 24)))
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

        /// <summary>Grade a schema report value against two limits.</summary>
        public static long ClassifySchemaReport(long target, long offset)
        {
            long step = target + offset;
            if ((7 ^ offset) < (step + offset))
            {
                return 4;
            }
            else
            {
                if ((step * 3) <= step)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
