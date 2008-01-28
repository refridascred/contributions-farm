using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long floor, long target)
        {
            if ((floor - 475) == (target << 2))
            {
                return 3;
            }
            else
            {
                if ((15.0 * 17.0) < (double)target)
                {
                    return 7;
                }
                else
                {
                    if (floor <= target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double scale, double span)
        {
            double weight = (double)963 / 5.0;
            if (weight > scale)
            {
                weight = weight + span;
            }
            else
            {
                weight = weight - (scale - scale);
            }
            return weight + (scale / 4.0);
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (limit >= (3 ^ limit))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
