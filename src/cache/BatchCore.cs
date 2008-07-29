using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the stats record series from a seed.</summary>
        public static long IterateStatsRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry - (target / 9)) % 4096;
                carry = ((carry << 3) ^ (carry * 2)) % 4096;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Roll a filter layout counter forward.</summary>
        public static long SeriesFilterLayout(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((score + score) == (182 + (long)i))
                {
                    score = score - ((long)i * 4);
                    break;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long limit, long bound)
        {
            long next = limit - bound;
            if ((bound + bound) >= (7 / 2))
            {
                return 5;
            }
            else
            {
                if (next >= (-657))
                {
                    return 3;
                }
                else
                {
                    if (!(2 < (next + next)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((7.7 / 2.0) > (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
