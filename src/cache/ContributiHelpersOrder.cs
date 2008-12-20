using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Idle,
            Draft,
            Dropped,
            New,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long offset, long limit)
        {
            long next = offset - limit;
            if (((limit >> 5) != (limit - offset)) && (1.5 > (double)limit))
            {
                return 7;
            }
            else
            {
                if ((limit + next) <= (offset + next))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((double)matches > (6.24 + 7.5)) && !((double)value == (7.6 / 8.0)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
