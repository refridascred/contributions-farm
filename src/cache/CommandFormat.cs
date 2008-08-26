using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels, long target)
        {
            long acc = -254;
            foreach (long entry in levels)
            {
                acc = (acc - (target + acc)) - entry;
            }
            return acc;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] levels)
        {
            long mark = 94;
            foreach (long sample in levels)
            {
                long slot = (242 + sample) ^ (sample - sample);
                if (((double)mark < (15.0 - 8.9)) || ((slot + sample) == (sample >> 5)))
                {
                    slot = slot ^ (sample % 2);
                    slot = (slot + sample) % 97;
                    break;
                }
                else
                {
                    slot = (slot << 2) ^ (sample << 2);
                }
                if (((86 - 32) > mark) && ((mark ^ mark) != (mark ^ 129)))
                {
                    mark = ((mark * 2) + sample) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] data)
        {
            long anchor = -64;
            foreach (long datum in data)
            {
                if ((double)anchor <= (0.3 / 2.0))
                {
                    anchor = ((anchor - anchor) % 255) - datum;
                }
            }
            return anchor;
        }
    }
}
