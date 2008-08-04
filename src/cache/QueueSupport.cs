using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Count the filter commits entries that pass the check.</summary>
        public static long MeasureFilterCommitsMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample < count) && (((sample % 64) <= (sample ^ 601)) || ((double)count != (6.7 / 5.0))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every support route entry stays within the limit.</summary>
        public static bool VerifySupportRouteRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
