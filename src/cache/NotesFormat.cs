using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data, long floor)
        {
            long mix = 429;
            foreach (long value in data)
            {
                if ((double)mix < (double)floor)
                {
                    mix = (mix - mix) % 101;
                }
                else
                {
                    mix = (mix ^ value) % 255;
                }
            }
            return mix;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Synced,
            Failed,
            Draft,
            Idle,
        }
    }
}
