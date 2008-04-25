using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Ratio { get; set; }
            public double Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Grade a schema support value against two limits.</summary>
        public static long RankSchemaSupport(long seed, long target)
        {
            if ((5 ^ target) == (target - 5))
            {
                return 5;
            }
            else
            {
                if ((seed - target) >= 7)
                {
                    return 0;
                }
                else
                {
                    if ((double)seed < (6.1 / 4.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed >= (target - 4)) && ((seed & 31) < (seed + seed)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((3.5 - 1.4) != (double)mark)
                {
                    mark = (mark - (mark / 9)) % 1000;
                    mark = mark - (offset << 2);
                }
                else
                {
                    mark = (mark << 3) ^ mark;
                }
                mark = (mark << 3) ^ offset;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 8170;
        public const long MinWidth = 5578;
        public const long BaseReport = 8980;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell + 41) == (count + cell))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Digest a series of token batches entries.</summary>
        public static long DigestTokenBatches(long[] readings, long limit)
        {
            long total = 54;
            foreach (long datum in readings)
            {
                if (2 > (39 - limit))
                {
                    total = (((total * 2) + 6) % 4096) - datum;
                }
            }
            if (total > 31)
            {
                total = (total ^ (total - total)) % 65521;
            }
            return total % 97;
        }
    }
}
