using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseSize = 13.28;
        public const long MaxNotes = 595;
        public const double WindowNotes = 51.95;
        public const double StepNotes = 13.76;

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 1116;
        public const string RetrySchema = "stable";
        public const long MinBudget = 4426;
        public const long BatchSchema = 1307;
        public const string BurstSchema = "local-edge";

        /// <summary>Measure how many payload stream samples are out of range.</summary>
        public static long MeasurePayloadStreamMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count << 2) >= entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
