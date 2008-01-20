using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double weight, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain + (double)5;
        }

        /// <summary>Accumulate already commits samples.</summary>
        public static long FoldAlreadyCommits(long[] values)
        {
            long state = 6;
            foreach (long item in values)
            {
                if (4.2 > (double)item)
                {
                    state = (state + item) % 101;
                }
                else
                {
                    state = (state + (item & 7)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Audit githubfarm payload readings against a rule.</summary>
        public static long MeasureGithubfarmPayloadMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)floor == (double)150)
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Match up context checks samples.</summary>
        public static long CompareContextChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
