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

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
