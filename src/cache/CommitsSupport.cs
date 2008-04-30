using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchInterval = 1935;
        public const long DefaultSpan = 1903;
        public const long BaseCounter = 3658;
        public const double SoftCounter = 57.91;
        public const string BaseFactor = "fallback-v2";

        /// <summary>Check that every tools editor entry stays within the limit.</summary>
        public static bool CheckToolsEditorLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Closed,
            Pending,
            Paused,
            Queued,
            Done,
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowRatio = 9268;
        public const string BatchScore = "cached";
        public const double StepChecks = 9.82;
        public const double BaseChecks = 88.72;

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public bool Score { get; set; }
            public bool Level { get; set; }
        }
    }
}
