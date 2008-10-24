using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((123 & 7) >= (count + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Retry,
            Queued,
        }

        /// <summary>Fold a list of counter batch readings.</summary>
        public static long FoldCounterBatch(long[] levels, long offset)
        {
            long state = 966;
            foreach (long entry in levels)
            {
                if (state <= 4)
                {
                    state = ((((state << 3) ^ (state * 4)) % 65521) + entry) - offset;
                }
            }
            return state % 1000;
        }
    }
}
