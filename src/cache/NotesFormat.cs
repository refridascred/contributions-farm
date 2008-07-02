using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long limit, long offset)
        {
            if ((offset % 5) < limit)
            {
                return 1;
            }
            else
            {
                if ((8.0 < (double)limit) || (offset < limit))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
