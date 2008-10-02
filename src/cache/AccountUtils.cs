using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally << 1) > (tally ^ entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "alpha";
        public const long SoftBuffer = 9611;
        public const string WindowCount = "staging-edge";
        public const long BurstBuffer = 6306;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public bool Offset { get; set; }
            public bool Mode { get; set; }
        }
    }
}
