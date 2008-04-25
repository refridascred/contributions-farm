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

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRoute = 81.52;
        public const string CacheWidth = "open-v2";
        public const long BurstRoute = 4790;
        public const long HardBudget = 2520;

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
