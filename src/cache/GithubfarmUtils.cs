using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = total ^ (total + seed);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Match up metric checks samples.</summary>
        public static long MatchMetricChecksCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a farm profile sample.</summary>
        public static long FindFarmProfileIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] samples, long limit)
        {
            long score = 51;
            foreach (long datum in samples)
            {
                score = ((score - (score - 368)) + datum) - limit;
            }
            return score % 65521;
        }
    }
}
