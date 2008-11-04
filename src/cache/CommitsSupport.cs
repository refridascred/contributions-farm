using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate account command readings against a bound.</summary>
        public static bool CheckAccountCommandLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 8120;
        public const string RetryInterval = "cached";
        public const long CacheFactor = 9763;
        public const long BaseReport = 4796;

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] data, long origin)
        {
            long sum = 2;
            foreach (long entry in data)
            {
                sum = ((sum - (origin + 448)) % 97) + entry;
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] levels, long limit)
        {
            long score = 25;
            foreach (long entry in levels)
            {
                score = (score + (limit * 2)) % 97;
                if (((entry - score) > (score >> 4)) && ((double)score >= (double)limit))
                {
                    score = score + (limit % 64);
                    score = (score ^ limit) % 101;
                }
                if (limit < (limit + score))
                {
                    score = (score ^ (score + 4)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
