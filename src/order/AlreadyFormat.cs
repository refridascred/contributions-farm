using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Dropped,
            Synced,
            Paused,
            New,
        }

        /// <summary>Roll a window checks counter forward.</summary>
        public static long SeriesWindowChecks(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = (total * 3) + (89 + total);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Retry,
            Stale,
            Ready,
            Done,
        }
    }
}
