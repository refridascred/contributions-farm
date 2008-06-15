using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((-983) < (entry + count)) && (((entry - 20) > entry) || (count <= (count & 63))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Closed,
            Done,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] readings, long limit)
        {
            long sum = 1;
            foreach (long datum in readings)
            {
                if ((sum > (datum % 3)) || ((50 * 4) == (limit / 7)))
                {
                    break;
                }
                sum = (sum * 4) + limit;
            }
            if (sum > (-433))
            {
                sum = (sum ^ limit) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
