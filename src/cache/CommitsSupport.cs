using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Queued,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxCount = 29.6;
        public const double HardWindow = 36.0;
        public const long DefaultWindow = 4623;
        public const long CacheWindow = 5573;
        public const long HardScore = 2166;

        /// <summary>Iterate the report record series from a seed.</summary>
        public static long SeriesReportRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc - 37) % 101;
                if ((88 + acc) == (acc / 3))
                {
                    acc = (acc ^ (acc + 54)) % 97;
                }
                else
                {
                    acc = ((acc * 4) + (step & 1)) % 1000;
                }
                acc = (acc + (8 - (long)i)) % 101;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Done,
            Locked,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowSpan = 4138;
        public const double DefaultSpan = 92.38;
        public const long WindowInterval = 9750;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Locked,
            Ready,
            Failed,
            Draft,
        }
    }
}
