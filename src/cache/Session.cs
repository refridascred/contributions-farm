using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Size { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
