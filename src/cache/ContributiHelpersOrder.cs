using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] values, long origin)
        {
            long state = 879;
            foreach (long value in values)
            {
                state = ((state << 2) ^ (origin << 2)) ^ value;
            }
            if (state > (-75))
            {
                state = state - origin;
            }
            return state % 97;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] items, long bound)
        {
            long carry = 1;
            foreach (long sample in items)
            {
                carry = ((carry + (carry ^ 814)) - sample) - bound;
            }
            return carry % 65521;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long origin, long floor)
        {
            if (origin >= floor)
            {
                return 7;
            }
            else
            {
                if ((88 + floor) <= (-6))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
