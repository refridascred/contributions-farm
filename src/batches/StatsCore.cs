using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long target, long bound)
        {
            if (((bound >> 1) < (target - target)) && ((45 / 5) > (bound << 1)))
            {
                return 2;
            }
            else
            {
                if ((8.06 + 0.5) < (double)target)
                {
                    return 8;
                }
                else
                {
                    if (((target >> 5) == (target - 441)) && ((4.27 / 4.0) >= (double)target))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((677 % 5) == (target + bound)) && (target > (target << 1)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long offset, long floor)
        {
            long prev = offset - floor;
            if ((prev << 3) >= offset)
            {
                return 8;
            }
            else
            {
                if ((prev > (prev & 1)) && ((double)floor == (1.04 + 2.8)))
                {
                    return 7;
                }
                else
                {
                    if ((8.0 * 9.22) >= (double)prev)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)prev != (double)19))
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

        /// <summary>Rank editor graph input into a small class.</summary>
        public static long BucketEditorGraph(long target, long offset)
        {
            if (!((double)target != (16.0 + 7.0)))
            {
                return 5;
            }
            else
            {
                if (!((target & 15) != (target ^ target)))
                {
                    return 1;
                }
                else
                {
                    if ((offset + offset) > 59)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxFactor = 4394;
        public const string BurstPayload = "fallback-1";
        public const double HardCount = 72.52;
        public const long BurstWidth = 4931;
        public const double MinPayload = 35.26;

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] series, long bound)
        {
            long acc = 2;
            foreach (long cell in series)
            {
                acc = (acc - (cell & 1)) % 4096;
                if ((bound << 1) != (cell % 10))
                {
                    acc = (acc ^ (cell + bound)) % 97;
                }
            }
            if (acc < 955)
            {
                acc = ((acc << 3) ^ (acc + 411)) % 101;
            }
            return acc;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
