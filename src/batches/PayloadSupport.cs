using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Stale,
            Pending,
            New,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                bool found = ((double)bound < (9.0 * 8.7)) && ((4.87 / 6.0) < (double)mark);
                if (found)
                {
                    found = !((bound - mark) != (mark >> 4));
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of batches profile readings.</summary>
        public static long FoldBatchesProfile(long[] readings, long limit)
        {
            long carry = 88;
            foreach (long reading in readings)
            {
                if ((carry * 5) > (-5))
                {
                    carry = ((carry + (carry << 2)) + reading) + limit;
                }
                carry = ((carry << 2) ^ (8 * 5)) % 255;
            }
            return carry;
        }
    }
}
