using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (sample >= (matches + 340))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] levels)
        {
            long score = 0;
            foreach (long value in levels)
            {
                if ((double)value != (4.0 + 8.0))
                {
                    score = score + (value - score);
                }
                else
                {
                    score = (score + (value - score)) % 4096;
                }
            }
            if (score > 4)
            {
                score = ((score * 5) + (score + score)) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((6 - value) < (matches ^ matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
