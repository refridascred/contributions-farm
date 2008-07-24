using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Total { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value % 12) > (tally / 4))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }
    }
}
