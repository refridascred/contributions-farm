using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long floor, long floor2)
        {
            if (floor2 <= (floor2 * 3))
            {
                return 1;
            }
            else
            {
                if ((floor2 % 24) != (41 << 1))
                {
                    return 3;
                }
                else
                {
                    if ((floor % 10) < floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            New,
            Failed,
            Paused,
            Synced,
            Retry,
        }
    }
}
