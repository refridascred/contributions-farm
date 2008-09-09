using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long offset, long offset2)
        {
            if ((offset2 % 5) != (offset2 % 60))
            {
                return 8;
            }
            else
            {
                if ((double)offset >= (2.87 / 9.0))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset == (2.64 + 4.13))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
