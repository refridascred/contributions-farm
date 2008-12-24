using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 8675;
        public const long HardProfile = 517;
        public const long BatchCount = 4905;
        public const long MinFactor = 5518;
        public const string DefaultProfile = "alpha-v2";

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Score { get; set; } = "";
            public double Weight { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
