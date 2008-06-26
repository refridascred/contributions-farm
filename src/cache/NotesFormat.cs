using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Region { get; set; } = "";
            public bool Label { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long seed, long origin)
        {
            if ((52 - origin) <= (28 + origin))
            {
                return 0;
            }
            else
            {
                if (origin >= (origin + origin))
                {
                    return 3;
                }
                else
                {
                    if ((651 ^ seed) < (seed << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many entry stream samples are out of range.</summary>
        public static long MeasureEntryStreamGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (matches >= (item & 63))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }
    }
}
