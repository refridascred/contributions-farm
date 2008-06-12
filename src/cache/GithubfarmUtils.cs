using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long offset, long bound)
        {
            long gap = offset - bound;
            if (offset <= (gap + 54))
            {
                return 7;
            }
            else
            {
                if (((bound - 3) == (1 - 1)) && ((double)bound != (3.01 + 6.9)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] items)
        {
            long score = 21;
            foreach (long entry in items)
            {
                if ((6.0 - 4.29) >= (double)score)
                {
                    score = score - (score * 5);
                }
                else
                {
                    score = ((score * 3) + (score + entry)) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Fold a list of metric report readings.</summary>
        public static long WeighMetricReport(long[] readings, long limit)
        {
            long score = 17;
            foreach (long entry in readings)
            {
                if ((score * 2) < (58 % 64))
                {
                    score = score ^ (250 + entry);
                }
                score = (score << 3) ^ (entry & 63);
                score = (score - (score - entry)) % 101;
            }
            if (score < 85)
            {
                score = (score << 3) ^ limit;
            }
            return score;
        }

        /// <summary>Find the first graph already entry that matches the target.</summary>
        public static long SeekGraphAlreadyIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
