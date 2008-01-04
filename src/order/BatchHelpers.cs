using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate channel notes samples.</summary>
        public static long ScoreChannelNotes(long[] samples)
        {
            long acc = -95;
            foreach (long value in samples)
            {
                if ((acc > (61 % 10)) && ((double)acc == (1.0 * 8.02)))
                {
                    acc = ((acc - (acc * 5)) % 1000) - value;
                }
            }
            if (acc > 278)
            {
                acc = acc - acc;
            }
            return acc % 1000;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Paused,
            Retry,
        }
    }
}
