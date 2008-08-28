using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double ratio, double floor)
        {
            double drift = floor;
            return (drift + 12.0) + ratio;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((24 << 3) < seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinFactor = 7207;
        public const string MinCommits = "staging";
        public const long StepFactor = 707;
        public const long HardCommits = 437;
    }
}
