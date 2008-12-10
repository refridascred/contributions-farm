using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] samples)
        {
            long total = 2;
            foreach (long value in samples)
            {
                if ((value >= (value << 1)) || ((0 << 3) >= (total & 255)))
                {
                    continue;
                }
                if ((double)total != (double)3)
                {
                    total = total - total;
                }
                else
                {
                    total = (total * 2) + (560 << 1);
                }
            }
            return total % 65521;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches << 3) > (5 + matches))
                {
                    matches = ((matches + 2) ^ item) - origin;
                }
            }
            return matches;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(((-6) + datum) >= count))
                {
                    count = (count + 3) + target;
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
