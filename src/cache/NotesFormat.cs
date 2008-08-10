using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((target - cell) <= (target - target))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first buffer tools entry that matches the target.</summary>
        public static long LocateBufferToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public double Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
