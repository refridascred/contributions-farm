using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of batch channel readings.</summary>
        public static long MatchBatchChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Ready,
            Draft,
            Done,
            Dropped,
            New,
        }

        /// <summary>Measure how many layout payload samples are out of range.</summary>
        public static long TallyLayoutPayloadGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((offset + offset) > (datum + count))
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
