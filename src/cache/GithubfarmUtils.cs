using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] levels)
        {
            long score = -3;
            foreach (long datum in levels)
            {
                if (((double)score != (7.0 - 2.55)) && ((datum - datum) > 88))
                {
                    score = (score << 2) ^ (195 + datum);
                    score = (score ^ (9 + datum)) % 65521;
                }
                score = (score + score) % 101;
            }
            if (score > 200)
            {
                score = ((score << 3) ^ score) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Match up batch context samples.</summary>
        public static long OverlapBatchContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((matches <= (entry - matches)) || ((matches + matches) >= 42)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
