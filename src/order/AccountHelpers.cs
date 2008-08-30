using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(((count << 1) <= count) || ((item >> 3) <= (count - item))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] items)
        {
            long anchor = 9;
            foreach (long reading in items)
            {
                if ((reading + reading) < 0)
                {
                    anchor = (anchor << 3) ^ (anchor * 4);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Count metric already pairs that satisfy a relation.</summary>
        public static long CompareMetricAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next graph window value from a seed.</summary>
        public static long RollGraphWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                state = ((state << 3) ^ (seed << 1)) % 4096;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many buffer payload samples are out of range.</summary>
        public static long CountBufferPayloadGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell * 5) < 18)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
