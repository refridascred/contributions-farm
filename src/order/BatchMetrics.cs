using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every session metrics entry stays within the limit.</summary>
        public static bool CheckSessionMetricsBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate tools account readings against a bound.</summary>
        public static bool ValidateToolsAccountBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a support counter counter forward.</summary>
        public static long RollSupportCounter(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry ^ (long)i) % 4096;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry - count) <= (7 + count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            Synced,
            Idle,
            Pending,
            Draft,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = (score + (long)i) % 1000;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
