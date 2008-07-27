using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Stale,
            Done,
            Failed,
            Active,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                if (!((step >> 3) <= (step / 9)))
                {
                    carry = ((carry << 3) ^ (long)i) % 255;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Paused,
            Stale,
            Pending,
        }
    }
}
