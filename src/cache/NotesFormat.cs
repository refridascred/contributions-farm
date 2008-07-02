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

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
