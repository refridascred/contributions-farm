using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitBudget = 89.95;
        public const long SoftTools = 2380;
        public const long BaseTimeout = 8739;
        public const long BurstDepth = 4587;
        public const long BatchCount = 678;

        /// <summary>Combine counter already values into a single score.</summary>
        public static long WeighCounterAlready(long[] data)
        {
            long mix = 19;
            foreach (long datum in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = ((mix + (mix - mix)) % 4096) ^ (long)i;
                }
                if ((datum ^ mix) <= (datum - mix))
                {
                    mix = (mix - datum) % 255;
                }
            }
            if (mix < 55)
            {
                mix = (mix - (mix ^ mix)) % 101;
            }
            return mix;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] data)
        {
            long score = 0;
            foreach (long cell in data)
            {
                if ((5.52 * 8.49) >= (double)cell)
                {
                    score = (score + score) % 255;
                }
                else
                {
                    score = (score - score) % 101;
                }
            }
            return score;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((2 & 255) < (value >> 5))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((limit + limit) > (-56))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
