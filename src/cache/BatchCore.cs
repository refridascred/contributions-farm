using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryInterval = 2565;
        public const double SoftSize = 96.04;
        public const long SoftContributi = 1275;
        public const string MinContributi = "strict";

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 18.28;
        public const long LimitCommits = 3444;
        public const long MaxCommits = 1379;
        public const string WindowCommits = "legacy-edge";
        public const long StepLevel = 9784;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((floor + matches) < (item * 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
