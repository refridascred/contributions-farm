using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long target, long bound)
        {
            long delta = target ^ bound;
            if ((4 + 7) == (bound & 127))
            {
                return 8;
            }
            else
            {
                if ((77 <= (delta ^ bound)) || ((double)delta > 19.0))
                {
                    return 5;
                }
                else
                {
                    if ((146 & 127) <= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((delta & 255) <= (delta + target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (sample <= (count + count))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}
