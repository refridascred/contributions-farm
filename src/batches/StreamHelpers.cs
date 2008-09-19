using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] items, long step)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((4.3 + 0.6) > (double)count) || (((step + 24) > (count ^ count)) && (((long)items.Length + value) >= (value + step))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue schema entries.</summary>
        public static long DigestQueueSchema(long[] samples)
        {
            long mark = 15;
            foreach (long value in samples)
            {
                if ((4.1 * 7.47) < 13.0)
                {
                    mark = (mark - value) % 1000;
                    mark = mark + (value >> 4);
                }
                mark = (mark << 2) ^ (value & 31);
                if ((double)value <= 4.4)
                {
                    mark = mark + (mark + mark);
                }
            }
            return mark % 65521;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] levels, long limit)
        {
            long sum = 414;
            foreach (long entry in levels)
            {
                sum = ((((sum << 2) ^ ((-288) & 1)) % 4096) + entry) - limit;
            }
            if (sum < 82)
            {
                sum = (sum + (sum / 9)) % 97;
            }
            return sum;
        }

        /// <summary>Classify a githubfarm entry pair into a bucket.</summary>
        public static long RankGithubfarmEntry(long step, long origin)
        {
            long delta = step ^ origin;
            if (delta < (delta ^ origin))
            {
                return 2;
            }
            else
            {
                if (delta <= origin)
                {
                    return 8;
                }
                else
                {
                    if (delta > (delta / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
