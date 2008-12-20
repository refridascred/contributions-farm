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

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Closed,
            Failed,
            Idle,
            New,
        }

        /// <summary>Rank schema commits input into a small class.</summary>
        public static long ClassifySchemaCommits(long target, long limit)
        {
            long next = target + limit;
            if ((target / 4) == (next % 97))
            {
                return 4;
            }
            else
            {
                if (((limit ^ limit) <= (target - target)) || ((limit * 5) <= (next / 8)))
                {
                    return 2;
                }
                else
                {
                    if ((limit * 2) >= (limit * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
