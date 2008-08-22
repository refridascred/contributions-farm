using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Rank { get; set; }
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Total { get; set; }
            public double Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((6.8 - 7.27) <= (double)origin)
                {
                    break;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a batch command sample.</summary>
        public static long LocateBatchCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
