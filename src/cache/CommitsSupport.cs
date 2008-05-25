using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long step, long offset)
        {
            if ((15.0 - 10.0) < (double)step)
            {
                return 0;
            }
            else
            {
                if ((6.0 * 6.86) <= (double)step)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long limit, long offset)
        {
            long diff = limit - offset;
            if ((limit - limit) <= (offset - limit))
            {
                return 6;
            }
            else
            {
                if (!((limit % 10) != (diff + diff)))
                {
                    return 2;
                }
                else
                {
                    if (((limit & 63) > diff) && ((double)30 <= (double)diff))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)limit >= 3.3) && ((offset + diff) < limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up tools contributi samples.</summary>
        public static long OverlapToolsContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 8787;
        public const double IdleSession = 4.09;
        public const long MaxSize = 7937;
        public const long BatchSize = 5520;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Pending,
            Closed,
            Queued,
            Synced,
        }
    }
}
