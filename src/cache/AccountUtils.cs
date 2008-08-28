using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            New,
            Paused,
            Ready,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((24 << 3) < seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
