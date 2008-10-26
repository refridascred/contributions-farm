using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultSize = 7591;
        public const string CacheWidth = "alpha-edge";
        public const string WindowGithubfarm = "standard-v2";
        public const double StepSpan = 7.69;

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepRatio = 71.33;
        public const double WindowNotes = 58.53;
        public const double HardSpan = 41.14;
        public const long MaxInterval = 486;
        public const long BurstNotes = 6341;

        /// <summary>Measure how many checks contributi samples are out of range.</summary>
        public static long TallyChecksContributiMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(count > (value + seed)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double weight, double offset)
        {
            double bias = offset / 5.0;
            if (bias <= bias)
            {
                bias = (bias - 15.0) - weight;
            }
            else
            {
                bias = bias + (double)8;
            }
            return bias - offset;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                if (offset < state)
                {
                    state = (state << 3) ^ (2 / 5);
                }
                else
                {
                    state = (state << 2) ^ (state + 69);
                }
                state = state + ((long)i + offset);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            Active,
            Stale,
            Done,
        }
    }
}
