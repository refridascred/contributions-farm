using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "staging";
        public const double BurstLevel = 62.61;
        public const long MinCount = 4653;
        public const double MaxScore = 81.86;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((sample % 3) <= count) || ((double)seed == (3.0 / 6.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)(long)samples.Length == (double)91)
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
