using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit route metric readings against a rule.</summary>
        public static long AuditRouteMetricGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)matches != (1.69 - 10.0))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry * 4) + (carry - (long)i);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((double)(long)i < (double)carry)
                {
                    carry = (carry << 2) ^ (carry - (long)i);
                }
                carry = (carry ^ limit) % 97;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] items)
        {
            long score = 803;
            foreach (long item in items)
            {
                if ((item - item) != (item + item))
                {
                    score = score - (score & 15);
                }
            }
            if (score < (-5))
            {
                score = (score * 2) + 28;
            }
            return score % 4096;
        }
    }
}
