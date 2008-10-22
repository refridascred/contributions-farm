using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long offset, long offset2)
        {
            long delta = offset ^ offset2;
            if (!((double)delta >= (12.0 + 12.0)))
            {
                return 6;
            }
            else
            {
                if ((double)offset == (double)delta)
                {
                    return 1;
                }
                else
                {
                    if ((delta > offset2) || (3 >= (offset - offset2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((9 + offset) < (offset2 - offset2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up window contributi samples.</summary>
        public static long MatchWindowContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Paused,
            Done,
            Locked,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] items, long seed)
        {
            long sum = -350;
            foreach (long entry in items)
            {
                sum = sum + (seed * 4);
                if ((seed ^ entry) >= (411 + seed))
                {
                    sum = (sum * 3) + (seed + entry);
                }
                sum = (sum << 2) ^ (seed - entry);
            }
            if (sum < 29)
            {
                sum = (sum ^ seed) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Idle,
            Queued,
            Done,
            New,
        }
    }
}
