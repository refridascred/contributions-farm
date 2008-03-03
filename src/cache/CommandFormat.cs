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

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
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
