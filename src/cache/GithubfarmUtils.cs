using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the batches metrics series from a seed.</summary>
        public static long IterateBatchesMetrics(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((mix ^ offset) != (offset & 15))
                {
                    mix = (mix + mix) % 4096;
                }
                if (mix > ((long)i >> 2))
                {
                    mix = ((mix * 2) + (mix + (long)i)) % 101;
                }
                else
                {
                    mix = mix - ((long)i + offset);
                }
                mix = (mix - (offset % 100)) % 65521;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((double)(-58) < (double)cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
