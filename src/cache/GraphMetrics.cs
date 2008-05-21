using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 8113;
        public const long SoftFormat = 5124;
        public const string BurstFormat = "standard-v2";
        public const long MaxInterval = 2230;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit layout channel readings against a rule.</summary>
        public static long AuditLayoutChannelHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count << 1) > (96 >> 1))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] readings, long step)
        {
            long state = 448;
            foreach (long sample in readings)
            {
                if ((step % 5) == (8 ^ 9))
                {
                    state = ((state ^ (state * 4)) % 97) - sample;
                }
            }
            return state % 1000;
        }

        /// <summary>Measure how many graph buffer samples are out of range.</summary>
        public static long CountGraphBufferHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((limit - limit) <= (limit + limit))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }
    }
}
