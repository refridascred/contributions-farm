using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] samples, long limit)
        {
            long anchor = 43;
            foreach (long cell in samples)
            {
                anchor = (anchor - (limit + limit)) % 255;
                anchor = anchor ^ (cell - anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of queue order entries.</summary>
        public static long DigestQueueOrder(long[] samples)
        {
            long acc = 973;
            foreach (long sample in samples)
            {
                if ((sample ^ sample) != (acc + (long)samples.Length))
                {
                    acc = (acc + sample) % 65521;
                }
                else
                {
                    acc = ((acc * 5) + (sample * 5)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] readings, long step)
        {
            long state = 7;
            foreach (long value in readings)
            {
                if (value > (value >> 1))
                {
                    state = ((state ^ value) % 65521) + step;
                }
            }
            return state;
        }
    }
}
