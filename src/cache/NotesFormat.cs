using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] levels)
        {
            long acc = 95;
            foreach (long value in levels)
            {
                if ((double)value >= (8.1 - 4.4))
                {
                    acc = (acc * 4) + (228 + (-295));
                    break;
                }
                else
                {
                    acc = (acc + (acc + (long)levels.Length)) % 4096;
                    acc = (acc * 4) + (acc - 94);
                }
                acc = (acc ^ (4 * 5)) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of stream support readings.</summary>
        public static long CompareStreamSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches > (matches + matches))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
