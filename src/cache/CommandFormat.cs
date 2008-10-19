using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Retry,
            Pending,
            Done,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Retry,
            Failed,
            Locked,
            Active,
            Closed,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value <= (value * 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
