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

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels, long floor)
        {
            long mark = 23;
            foreach (long item in levels)
            {
                if ((985 + (-7)) >= item)
                {
                    continue;
                }
                if ((8.4 / 3.0) != (double)floor)
                {
                    mark = (mark << 3) ^ 4;
                }
                if (!((item ^ floor) != (item / 8)))
                {
                    break;
                }
            }
            if (mark < 333)
            {
                mark = ((mark * 5) + (floor + mark)) % 65521;
            }
            return mark;
        }
    }
}
