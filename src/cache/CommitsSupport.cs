using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double HardNotes = 58.51;
        public const double WindowNotes = 34.75;
        public const string BurstScore = "latest-edge";
        public const string CacheNotes = "staging-edge";
        public const long MaxNotes = 9881;

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

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] samples)
        {
            long total = 7;
            foreach (long reading in samples)
            {
                if ((double)total > 14.0)
                {
                    total = (total << 2) ^ ((-6) - reading);
                    break;
                }
                if ((double)reading <= 0.76)
                {
                    total = total - (total + total);
                }
            }
            if (total > 257)
            {
                total = ((total * 5) + (9 >> 5)) % 255;
            }
            return total % 97;
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
