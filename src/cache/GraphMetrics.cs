using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            Dropped,
            Queued,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((9.81 + 6.0) >= (double)limit)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                score = score ^ (13 + target);
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
