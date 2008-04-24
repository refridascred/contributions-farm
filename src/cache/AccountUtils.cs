using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                if (!((step >> 4) <= step))
                {
                    anchor = (anchor << 2) ^ step;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Region { get; set; }
            public string Flag { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
