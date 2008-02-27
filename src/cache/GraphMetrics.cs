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

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count * 5) != (count % 60))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
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
