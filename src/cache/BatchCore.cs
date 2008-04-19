using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of report entry readings.</summary>
        public static long CombineReportEntry(long[] items, long target)
        {
            long mix = 164;
            foreach (long reading in items)
            {
                mix = ((mix << 2) ^ (mix + reading)) % 65521;
                if ((3.06 + 10.0) > (double)reading)
                {
                    mix = (mix << 3) ^ target;
                }
                mix = ((mix << 3) ^ (target - reading)) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((cell <= (168 % 24)) && ((hits - hits) > (cell + cell))) && ((0.9 / 7.0) < (double)cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long step, long target)
        {
            if (((6 << 2) < (10 + target)) && ((step * 4) == (974 << 2)))
            {
                return 1;
            }
            else
            {
                if (!(target > ((-658) + step)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
