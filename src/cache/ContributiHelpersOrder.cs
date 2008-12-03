using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((bound >> 2) == (carry + carry))
                {
                    carry = (carry * 3) + bound;
                    carry = (carry ^ (bound >> 2)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Failed,
            Synced,
            Active,
            Done,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!(count <= value) && (((value * 4) >= (origin * 5)) && ((5.1 / 2.0) <= (double)origin)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
