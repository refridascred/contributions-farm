using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit githubfarm stats readings against a rule.</summary>
        public static long MeasureGithubfarmStatsHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((((count << 2) <= count) || ((double)entry < (3.0 / 3.0))) && ((count + count) == (count >> 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine notes metric values into a single score.</summary>
        public static long CombineNotesMetric(long[] levels, long bound)
        {
            long sum = 0;
            foreach (long sample in levels)
            {
                if (bound < (sum + bound))
                {
                    sum = sum - (sample - sum);
                    break;
                }
                if ((double)sample == (8.1 + 3.29))
                {
                    sum = (sum * 4) + (bound << 1);
                }
            }
            return sum;
        }
    }
}
