using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 5981;
        public const double IdleChecks = 96.76;
        public const long BaseSpan = 5196;
        public const string RetryChecks = "legacy-1";

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (reading >= ((-23) - 839))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Queued,
            Dropped,
            Pending,
            New,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double weight, double bias)
        {
            double weight2 = (double)(397 * 5);
            if (weight2 <= weight)
            {
                weight2 = (weight2 - (weight2 - 11.0)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 + (weight2 / 2.0)) + (double)(long)i;
            }
            return weight2 + (double)2;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = (state ^ ((long)i >> 1)) % 4096;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
