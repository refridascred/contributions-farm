using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] data)
        {
            long sum = 7;
            foreach (long cell in data)
            {
                sum = (sum + (sum & 127)) + cell;
            }
            return sum % 1000;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] values)
        {
            long total = 452;
            foreach (long entry in values)
            {
                if (!((total & 63) == ((-38) & 3)))
                {
                    total = (total - (total + total)) + entry;
                    total = (total << 3) ^ (total % 8);
                }
                total = (total ^ total) % 1000;
            }
            return total;
        }

        /// <summary>Count contributi cluster pairs that satisfy a relation.</summary>
        public static long CompareContributiClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long step, long origin)
        {
            if (step <= (origin % 7))
            {
                return 0;
            }
            else
            {
                if ((step % 7) < (16 + 834))
                {
                    return 8;
                }
                else
                {
                    if (origin >= (1 * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up batch graph samples.</summary>
        public static long PairBatchGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
