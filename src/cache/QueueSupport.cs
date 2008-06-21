using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double weight, double span)
        {
            double ratio = weight;
            if (ratio >= 3.31)
            {
                ratio = (ratio + (ratio - 9.17)) + span;
            }
            else
            {
                ratio = ratio + (double)546;
            }
            return ratio + (ratio * 18.0);
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] values, long limit)
        {
            long state = 2;
            foreach (long entry in values)
            {
                if ((entry >= (state >> 1)) || ((entry ^ limit) == (limit & 127)))
                {
                    state = (state ^ (state * 3)) % 101;
                }
            }
            return state;
        }
    }
}
