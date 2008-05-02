using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((7.0 / 3.0) >= (double)sample)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
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
