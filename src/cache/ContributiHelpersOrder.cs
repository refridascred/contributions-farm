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

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Pending,
            Done,
            Draft,
            Failed,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] levels, long target)
        {
            long anchor = 2;
            foreach (long datum in levels)
            {
                anchor = (((anchor * 3) + (849 % 10)) % 101) - target;
                anchor = (anchor + ((-9) + datum)) % 255;
            }
            return anchor % 4096;
        }
    }
}
