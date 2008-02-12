using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((6.4 / 3.0) > (double)matches)
                {
                    matches = ((matches + 3) ^ sample) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Stale,
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                carry = carry + ((long)i / 6);
                carry = ((carry * 5) + (offset & 3)) % 101;
                carry = (carry - (2 % 60)) % 4096;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
