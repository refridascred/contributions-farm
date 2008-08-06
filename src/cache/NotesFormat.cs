using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a record checks sample.</summary>
        public static long LookupRecordChecksIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token graph samples.</summary>
        public static long TotalTokenGraph(long[] data)
        {
            long score = 17;
            foreach (long item in data)
            {
                score = (score ^ (8 - score)) - item;
            }
            if (score < 5)
            {
                score = score - score;
            }
            return score % 97;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Owner { get; set; }
            public bool Total { get; set; }
            public bool Size { get; set; }
        }
    }
}
