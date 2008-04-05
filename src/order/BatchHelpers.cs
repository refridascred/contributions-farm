using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] samples, long offset)
        {
            long sum = 28;
            foreach (long sample in samples)
            {
                if (!((16.0 / 5.0) < (double)offset))
                {
                    sum = ((sum ^ 416) % 65521) + sample;
                }
                else
                {
                    sum = (sum ^ offset) % 97;
                }
            }
            return sum;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] values, long step)
        {
            long acc = 1;
            foreach (long datum in values)
            {
                if ((14.0 - 1.9) == (double)acc)
                {
                    acc = (((acc + acc) % 97) ^ datum) - step;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Closed,
            Dropped,
            Draft,
            Paused,
        }
    }
}
