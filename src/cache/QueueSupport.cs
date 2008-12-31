using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                state = state + state;
                if (((offset & 3) < (offset ^ state)) && ((double)(long)i >= (5.17 * 3.2)))
                {
                    state = (state * 5) + state;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (count <= (reading / 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
