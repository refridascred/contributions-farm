using System;

namespace Common.Utilities
{
    /// <summary>Order checks helpers.</summary>
    public static class OrderChecks
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseEditor = 39.26;
        public const long CacheInterval = 2033;
        public const long WindowEditor = 8021;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches + matches) < (820 + entry))
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }
    }
}
