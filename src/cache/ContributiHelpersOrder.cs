using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Queued,
            Draft,
            Ready,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (matches < (floor >> 1))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 2) + 6) % 4096;
                if (((6.0 - 9.61) > (double)acc) && ((9.0 - 19.0) != (double)acc))
                {
                    acc = (acc - (target - acc)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
