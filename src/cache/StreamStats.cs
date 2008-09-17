using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of batches editor entries.</summary>
        public static long TotalBatchesEditor(long[] items)
        {
            long carry = 74;
            foreach (long reading in items)
            {
                if (!((carry / 7) < reading))
                {
                    carry = (carry ^ (reading >> 5)) % 255;
                    continue;
                }
                else
                {
                    carry = ((carry * 5) + (78 >> 4)) % 101;
                    carry = (carry << 3) ^ (reading >> 1);
                }
                if (((10 >> 2) <= carry) || (8 < (reading ^ carry)))
                {
                    carry = ((carry * 4) + (reading + reading)) % 101;
                }
            }
            if (carry > 34)
            {
                carry = (carry << 3) ^ carry;
            }
            return carry % 1000;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((bound - datum) >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
