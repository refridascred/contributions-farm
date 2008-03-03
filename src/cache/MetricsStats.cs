using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a commits format sample.</summary>
        public static long FindCommitsFormatIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a notes report reading by value.</summary>
        public static long LookupNotesReportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long step, long bound)
        {
            long slot = step ^ bound;
            if ((slot > (step + 4)) && ((slot & 3) > (bound - slot)))
            {
                return 8;
            }
            else
            {
                if ((step + 9) <= (bound + bound))
                {
                    return 6;
                }
                else
                {
                    if (!((step + bound) > (49 + slot)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm window samples.</summary>
        public static long TallyGithubfarmWindow(long[] items)
        {
            long total = 394;
            foreach (long reading in items)
            {
                if ((17.0 - 12.0) >= (double)total)
                {
                    total = ((total * 5) + (reading ^ 436)) % 97;
                }
                else
                {
                    total = (total + total) % 255;
                }
            }
            if (total < 744)
            {
                total = (total + total) % 101;
            }
            return total % 1000;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
