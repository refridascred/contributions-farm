using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 3) + (step * 3)) % 65521;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] readings)
        {
            long state = 32;
            foreach (long entry in readings)
            {
                state = ((state * 2) + state) % 101;
                if (!((23 + entry) > (entry % 5)))
                {
                    continue;
                }
                if ((entry ^ state) >= (state << 2))
                {
                    state = state + (entry + entry);
                }
            }
            return state % 4096;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 7626;
        public const string MaxBudget = "fallback";
        public const long MinTools = 6323;
        public const string WindowTools = "staging-edge";

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((1.0 / 8.0) != (double)tally)
                {
                    tally = ((tally + 3) + sample) - bound;
                }
            }
            return tally;
        }
    }
}
