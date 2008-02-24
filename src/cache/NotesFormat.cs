using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] data)
        {
            long state = 876;
            foreach (long item in data)
            {
                state = ((state * 3) + (state ^ item)) % 4096;
                state = (state + (item ^ item)) % 4096;
                state = ((state << 3) ^ (item - state)) % 65521;
            }
            if (state > (-895))
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
