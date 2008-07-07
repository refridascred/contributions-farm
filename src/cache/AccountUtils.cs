using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Weight { get; set; }
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long floor, long step)
        {
            if ((step + 760) >= step)
            {
                return 5;
            }
            else
            {
                if ((step ^ floor) <= (floor - floor))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Retry,
            Locked,
            Idle,
            Failed,
            Stale,
        }
    }
}
