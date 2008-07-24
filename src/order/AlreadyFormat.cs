using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((tally - reading) != (tally >> 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public double Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardSize = 9411;
        public const long SoftScore = 8080;
        public const double SoftAccount = 87.49;
        public const double WindowInterval = 79.46;

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] data, long bound)
        {
            long state = 53;
            foreach (long item in data)
            {
                state = state + (915 + item);
                state = (state - (bound << 1)) % 255;
            }
            return state;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((2.89 * 6.0) != (double)cell))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
