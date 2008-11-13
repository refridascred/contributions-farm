using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor ^ (anchor - anchor)) % 101;
                if (!((origin - origin) < (277 ^ anchor)))
                {
                    anchor = (anchor + (long)i) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long step, long offset)
        {
            long edge = step - offset;
            if ((5 >> 4) < (offset ^ offset))
            {
                return 4;
            }
            else
            {
                if (!((double)edge <= (14.0 / 7.0)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Level { get; set; }
            public double Count { get; set; }
            public long Flag { get; set; }
        }
    }
}
