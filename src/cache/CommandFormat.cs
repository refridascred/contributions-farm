using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 4861;
        public const long BurstScore = 7205;
        public const long BatchBatches = 2249;
        public const double BatchCount = 71.26;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Flag { get; set; }
            public long Owner { get; set; }
            public bool Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((value ^ value) >= value) || ((double)seen == (2.5 - 4.46))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
