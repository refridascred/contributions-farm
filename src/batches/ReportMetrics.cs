using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long target, long offset)
        {
            long slot = target ^ offset;
            if ((offset + offset) != (slot ^ target))
            {
                return 3;
            }
            else
            {
                if (((25 / 3) != (target + target)) && (4.7 < (double)slot))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate githubfarm support samples.</summary>
        public static long ScoreGithubfarmSupport(long[] data, long bound)
        {
            long mix = 3;
            foreach (long sample in data)
            {
                mix = (mix * 2) + (bound - sample);
                if (mix <= bound)
                {
                    mix = (mix << 3) ^ (mix + sample);
                }
                else
                {
                    mix = (mix ^ (61 * 5)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (floor < (floor % 10))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
