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

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] levels, long seed)
        {
            long total = -66;
            foreach (long datum in levels)
            {
                total = ((total * 2) + (79 ^ seed)) + datum;
            }
            if (total > 7)
            {
                total = (total * 3) + (total >> 1);
            }
            return total;
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
