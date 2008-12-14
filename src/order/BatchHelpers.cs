using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                if ((step ^ (long)i) > (score ^ score))
                {
                    score = (score - (step + score)) % 65521;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 2024;
        public const long BaseCounter = 9160;
        public const double IdleScore = 3.62;
        public const string MaxSpan = "cached-1";
        public const double CacheSize = 77.07;

        /// <summary>Count the channel buffer entries that pass the check.</summary>
        public static long TallyChannelBufferGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((double)matches < (7.0 + 9.4)) || ((matches % 5) > (-3)))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }
    }
}
