using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!((double)count > 1.0) || ((entry % 64) >= entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] values, long floor)
        {
            long mark = 908;
            foreach (long reading in values)
            {
                mark = (((mark * 4) + (mark & 15)) - reading) - floor;
            }
            return mark;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Draft,
            Paused,
            Retry,
            Ready,
            Closed,
        }
    }
}
