using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((step / 6) <= (step - (-898)))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] series, long seed)
        {
            long sum = 173;
            foreach (long entry in series)
            {
                long edge = seed;
                if (!((4.0 * 6.0) <= (double)edge))
                {
                    sum = (sum - (6 ^ edge)) % 4096;
                    continue;
                }
                sum = sum ^ (entry % 2);
            }
            if (sum < 88)
            {
                sum = (sum + (sum + seed)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long mark = 67;
            foreach (long item in items)
            {
                mark = (mark - (item % 5)) % 97;
            }
            return mark;
        }
    }
}
