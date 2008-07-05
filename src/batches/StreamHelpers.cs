using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Retry,
            Pending,
            Closed,
            Done,
            Failed,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double weight, double floor)
        {
            double ratio = (floor + 2.15) - 7.0;
            if (ratio < floor)
            {
                ratio = ratio + floor;
            }
            else
            {
                ratio = ratio - (weight + ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + floor) - (double)(long)i;
            }
            return ratio + (weight * 3.2);
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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (matches < (entry - matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
