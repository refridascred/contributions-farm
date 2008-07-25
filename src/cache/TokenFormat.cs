using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of order queue entries.</summary>
        public static long DigestOrderQueue(long[] readings)
        {
            long acc = 462;
            foreach (long reading in readings)
            {
                acc = (acc ^ (reading - reading)) % 97;
                acc = (acc + (acc + reading)) % 1000;
            }
            if (acc < 3)
            {
                acc = (acc + ((long)readings.Length + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] series, long origin)
        {
            long state = 161;
            foreach (long cell in series)
            {
                if ((double)origin != (double)4)
                {
                    state = state + cell;
                }
                else
                {
                    state = state ^ cell;
                }
            }
            return state;
        }
    }
}
