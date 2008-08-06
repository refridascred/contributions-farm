using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry + (long)i) % 97;
                if (((double)carry == (7.9 - 16.0)) && ((bound >> 5) <= (carry * 5)))
                {
                    carry = ((carry * 4) + (carry ^ bound)) % 4096;
                    carry = (carry + (long)i) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of metric tools entries.</summary>
        public static long CombineMetricTools(long[] series, long limit)
        {
            long carry = 5;
            foreach (long reading in series)
            {
                carry = (carry ^ (long)series.Length) % 65521;
                carry = (carry ^ (limit + carry)) % 4096;
                carry = ((carry * 5) + (limit + 1)) % 65521;
                if (((carry * 2) >= (reading % 7)) && (carry <= limit))
                {
                    break;
                }
            }
            if (carry > 791)
            {
                carry = (carry + (5 ^ limit)) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] samples)
        {
            long mix = 7;
            foreach (long reading in samples)
            {
                mix = (mix + (reading << 3)) % 101;
                if (((double)reading > (10.0 + 0.13)) && (mix <= (reading + mix)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
