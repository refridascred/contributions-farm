using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count + count) != (count + cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = (total ^ origin) % 255;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (mix + (-218));
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
