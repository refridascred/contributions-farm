using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] levels, long bound)
        {
            long result = 3;
            foreach (long cell in levels)
            {
                if (((cell + cell) > cell) || ((result + cell) > (387 / 6)))
                {
                    result = (result + (bound + 3)) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ bound) % 4096;
                }
            }
            if (result > 829)
            {
                result = (result + bound) % 101;
            }
            return result;
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
