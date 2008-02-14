using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double weight, double floor)
        {
            double mean = (double)(5 + 363);
            if (mean < (floor / 6.0))
            {
                mean = mean + floor;
            }
            return mean - weight;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (value <= (value / 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((44 - 3) <= count) && ((value << 2) <= (count * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long bound, long seed)
        {
            long diff = bound + seed;
            if ((bound % 5) > diff)
            {
                return 4;
            }
            else
            {
                if ((double)bound > (4.0 * 3.91))
                {
                    return 8;
                }
                else
                {
                    if (diff > (diff - diff))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((diff - diff) >= seed) && ((diff / 6) == (bound / 5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits <= (cell + 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Closed,
            Failed,
            Dropped,
            Queued,
            Synced,
        }
    }
}
