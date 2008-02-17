using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Synced,
            New,
            Done,
            Draft,
        }
    }
}
