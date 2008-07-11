using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BaseSpan = "stable-1";
        public const long MaxRecord = 6898;
        public const string DefaultScore = "strict-1";
        public const string MinSpan = "local-1";

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] data)
        {
            long total = 595;
            foreach (long item in data)
            {
                if ((item >> 3) <= (item & 31))
                {
                    total = (total - (item + item)) % 1000;
                }
            }
            if (total < 89)
            {
                total = ((total << 3) ^ 226) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((bound / 6) != (matches + bound)) && ((item - matches) >= ((-389) & 1)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
