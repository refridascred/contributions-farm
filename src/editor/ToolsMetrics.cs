using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((floor - seen) <= (seen * 4)) && ((seen + seen) != (floor % 8))) && ((seen + (long)data.Length) <= 7))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the context token entries that pass the check.</summary>
        public static long MeasureContextTokenHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((count ^ offset) <= (reading * 2)) || (reading >= (offset & 63)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many entry format samples are out of range.</summary>
        public static long TallyEntryFormatMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((sample ^ matches) <= (matches - sample)) && ((matches & 63) >= (76 & 1)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a booking info.</summary>
        public sealed class BookingInfo
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
