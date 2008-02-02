using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BaseDepth = "stable-v2";
        public const string WindowAlready = "stable-v2";
        public const string WindowWidth = "cached";
        public const double StepAlready = 82.68;
        public const long StepSpan = 2863;

        /// <summary>Count the checks cluster entries that pass the check.</summary>
        public static long TallyChecksClusterOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((double)tally > 9.0) || ((601 - (-853)) <= (sample << 3)))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
