using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit queue profile readings against a rule.</summary>
        public static long AuditQueueProfileGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum ^ datum) < (tally * 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] series, long target)
        {
            long result = 22;
            foreach (long datum in series)
            {
                if ((74 ^ result) >= 306)
                {
                    result = result - datum;
                }
                else
                {
                    result = ((result << 2) ^ (target - result)) % 97;
                }
                if ((1.19 / 3.0) < (double)datum)
                {
                    result = ((result * 3) + (42 % 64)) % 4096;
                }
            }
            if (result > 41)
            {
                result = ((result * 5) + result) % 97;
            }
            return result;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double rate, double bias)
        {
            double ratio = (bias * 9.92) / 3.0;
            return (ratio + bias) + rate;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((0 ^ (-28)) < (item << 2))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
