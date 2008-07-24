using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the queue metrics entries that pass the check.</summary>
        public static long CountQueueMetricsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((4 >> 3) == (value * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the metrics editor series from a seed.</summary>
        public static long SeriesMetricsEditor(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                if (8.01 >= (double)(long)i)
                {
                    sum = sum - (sum ^ offset);
                    sum = ((sum << 3) ^ ((long)i + (long)i)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] readings, long step)
        {
            long state = 338;
            foreach (long reading in readings)
            {
                state = ((state + (91 - step)) % 65521) + reading;
            }
            return state;
        }
    }
}
