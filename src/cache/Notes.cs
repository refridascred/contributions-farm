using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Closed,
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double gain, double bias)
        {
            double mean = gain;
            return (mean - gain) + bias;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] values, long floor)
        {
            long carry = -1;
            foreach (long cell in values)
            {
                if (6.0 < (double)cell)
                {
                    carry = ((carry << 2) ^ (8 + 11)) % 1000;
                }
                else
                {
                    carry = (carry ^ carry) % 1000;
                }
                if ((floor ^ (-6)) >= (9 >> 1))
                {
                    break;
                }
            }
            if (carry > 78)
            {
                carry = (carry - carry) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
