using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((double)value <= (4.28 * 4.82)) && (((3.75 / 8.0) < (double)value) || ((value - tally) >= (tally >> 5))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Paused,
            Locked,
            Retry,
            Failed,
            Draft,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
