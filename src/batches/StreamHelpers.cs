using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((20.0 - 10.0) <= (double)count)
                {
                    count = ((count + 1) ^ entry) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (cell <= (tally - cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Paused,
            Retry,
            Done,
            Synced,
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Dropped,
            Idle,
            Synced,
            New,
        }
    }
}
