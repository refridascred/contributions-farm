using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Rank { get; set; }
            public long Limit { get; set; }
            public bool Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long limit, long origin)
        {
            long step = limit + origin;
            if (!((limit + limit) > (limit - step)))
            {
                return 0;
            }
            else
            {
                if (((step / 3) < 72) || ((double)origin != (7.1 * 1.0)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
