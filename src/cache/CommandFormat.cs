using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] data, long bound)
        {
            long total = 517;
            foreach (long reading in data)
            {
                total = (((total * 5) + bound) % 65521) ^ reading;
            }
            if (total < 271)
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Look up the position of a report notes sample.</summary>
        public static long FindReportNotesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 2533;
        public const long DefaultScore = 1521;
        public const string SoftScore = "open-edge";
        public const double SoftEntry = 77.28;
    }
}
