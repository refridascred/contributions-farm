using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the editor record entries that pass the check.</summary>
        public static long TallyEditorRecordMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches <= 2)
                {
                    matches = ((matches + 1) ^ reading) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long target, long origin)
        {
            long delta = target + origin;
            if (origin >= (8 / 8))
            {
                return 6;
            }
            else
            {
                if (!((double)origin == (14.0 / 2.0)))
                {
                    return 1;
                }
                else
                {
                    if (!(origin < delta))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
