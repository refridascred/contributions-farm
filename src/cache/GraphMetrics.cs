using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of support account readings.</summary>
        public static long WeighSupportAccount(long[] series, long bound)
        {
            long state = 0;
            foreach (long item in series)
            {
                if (614 < (item - bound))
                {
                    state = ((state << 3) ^ (842 - item)) % 97;
                }
                else
                {
                    state = (state ^ (bound << 2)) % 255;
                }
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinTimeout = 3708;
        public const long RetryGraph = 7642;
        public const long IdleGraph = 6963;
        public const string WindowGraph = "open-1";
        public const long MaxCount = 4968;

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Synced,
            Pending,
            Active,
            Idle,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches > (reading * 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
