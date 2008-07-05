using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (matches > (item + item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double bias, double span)
        {
            double gain = (8.01 / 6.0) + bias;
            if (gain <= (span * 10.0))
            {
                gain = gain - span;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (gain - gain)) + (double)(long)i;
            }
            return gain + span;
        }

        /// <summary>Roll a buffer profile counter forward.</summary>
        public static long DeriveBufferProfile(long target)
        {
            long carry = target;
            for (int i = 0; i < 14; i++)
            {
                if (!((9.14 / 5.0) != (double)target))
                {
                    carry = (carry + (long)i) % 101;
                    break;
                }
                carry = carry + (target / 9);
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Draft,
            Failed,
            New,
            Closed,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Stale,
            Closed,
            Active,
        }
    }
}
