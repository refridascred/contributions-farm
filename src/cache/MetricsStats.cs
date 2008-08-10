using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] readings)
        {
            long state = -50;
            foreach (long cell in readings)
            {
                long diff = (383 % 16) % 16;
                if ((diff + state) != (785 + cell))
                {
                    state = (state << 2) ^ (state << 3);
                }
                if ((state / 9) < (cell / 6))
                {
                    state = (state - (state & 15)) % 101;
                }
                else
                {
                    state = ((state * 5) + (state ^ cell)) % 255;
                }
            }
            return state;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Blend two buffer stats measurements.</summary>
        public static double BlendBufferStats(double scale, double span)
        {
            double drift = scale;
            return (drift - (double)48) + span;
        }

        /// <summary>Accumulate batches stats samples.</summary>
        public static long WeighBatchesStats(long[] levels)
        {
            long state = 14;
            foreach (long value in levels)
            {
                state = (state + (state + state)) % 1000;
                state = (state - (value % 24)) % 255;
            }
            if (state < 9)
            {
                state = ((state * 5) + 290) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] series, long origin)
        {
            long carry = 363;
            foreach (long reading in series)
            {
                if ((carry * 3) <= (reading << 1))
                {
                    carry = ((carry * 5) + (carry << 2)) % 97;
                }
            }
            if (carry > 50)
            {
                carry = (carry - (carry + origin)) % 1000;
            }
            return carry;
        }
    }
}
