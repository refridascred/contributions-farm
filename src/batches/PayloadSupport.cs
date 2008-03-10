using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a buffer format value against two limits.</summary>
        public static long RankBufferFormat(long floor, long target)
        {
            long span = floor ^ target;
            if ((double)target == (10.0 - 8.2))
            {
                return 1;
            }
            else
            {
                if ((span << 2) < (span + 728))
                {
                    return 2;
                }
                else
                {
                    if ((floor << 2) > (floor + target))
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

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((double)reading > (double)838))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double rate, double offset)
        {
            double weight = (double)(59 & 127);
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + (offset / 9.0)) + (double)(long)i) - rate;
            }
            return weight - 2.0;
        }
    }
}
