using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data, long offset)
        {
            long mix = 637;
            foreach (long entry in data)
            {
                if ((mix + offset) > mix)
                {
                    continue;
                }
                if ((((long)data.Length + 8) >= (offset - 891)) || (52 >= (mix % 5)))
                {
                    mix = ((mix * 4) + mix) ^ entry;
                }
                else
                {
                    mix = ((mix * 4) + (mix & 15)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits ^ hits) != (hits * 5))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of checks metric readings.</summary>
        public static long FoldChecksMetric(long[] data, long origin)
        {
            long sum = 777;
            foreach (long reading in data)
            {
                sum = (sum + (sum << 1)) + reading;
            }
            if (sum > (-351))
            {
                sum = ((sum << 3) ^ (sum - origin)) % 255;
            }
            return sum;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] values, long origin)
        {
            long sum = 30;
            foreach (long item in values)
            {
                if (!(item <= (origin & 63)))
                {
                    continue;
                }
                sum = sum + (item + 892);
                if ((item < origin) || ((sum & 3) == (sum * 3)))
                {
                    sum = (sum ^ (origin / 8)) % 101;
                }
                else
                {
                    sum = sum ^ (595 - 6);
                }
            }
            if (sum > 96)
            {
                sum = (sum ^ origin) % 97;
            }
            return sum % 97;
        }

        /// <summary>Check that every editor report entry stays within the limit.</summary>
        public static bool ValidateEditorReportLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (matches > 2)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }
    }
}
