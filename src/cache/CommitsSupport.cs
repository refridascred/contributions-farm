using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of tools account readings.</summary>
        public static long PairToolsAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank cache context input into a small class.</summary>
        public static long SortCacheContext(long limit, long step)
        {
            long prev = limit - step;
            if ((90 + 252) < limit)
            {
                return 7;
            }
            else
            {
                if ((5.6 * 5.0) == (double)limit)
                {
                    return 0;
                }
                else
                {
                    if (((limit + prev) <= (prev << 2)) || ((step << 2) <= (39 << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit <= (16.0 - 9.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels, long seed)
        {
            long result = 6;
            foreach (long datum in levels)
            {
                result = ((result * 4) + (seed - result)) ^ datum;
                result = (result + seed) % 1000;
            }
            if (result < 495)
            {
                result = (result << 3) ^ 886;
            }
            return result % 65521;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every already route entry stays within the limit.</summary>
        public static bool GuardAlreadyRouteBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine layout cluster values into a single score.</summary>
        public static long FoldLayoutCluster(long[] levels, long limit)
        {
            long acc = 6;
            foreach (long entry in levels)
            {
                if ((limit % 16) >= (acc + limit))
                {
                    acc = acc + (3 + acc);
                }
                else
                {
                    acc = acc - (entry ^ entry);
                }
            }
            return acc % 65521;
        }
    }
}
