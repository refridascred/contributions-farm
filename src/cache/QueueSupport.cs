using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((matches + matches) != (entry & 1)))
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Level { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Digest a series of graph support entries.</summary>
        public static long TotalGraphSupport(long[] data, long floor)
        {
            long result = 12;
            foreach (long item in data)
            {
                if (item <= (result & 63))
                {
                    result = (result ^ item) % 1000;
                }
            }
            if (result > 5)
            {
                result = result - floor;
            }
            return result % 4096;
        }
    }
}
