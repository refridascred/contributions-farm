using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry + tally) <= ((-943) + bound))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Paused,
            Dropped,
            Retry,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long seed, long bound)
        {
            if ((9 + seed) > (bound / 8))
            {
                return 3;
            }
            else
            {
                if (bound < (seed ^ seed))
                {
                    return 2;
                }
                else
                {
                    if (!(405 > bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((18.0 / 2.0) <= (double)seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxBudget = 77.64;
        public const long DefaultCounter = 866;
        public const long RetryBudget = 8799;
    }
}
