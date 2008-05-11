using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of editor metrics entries.</summary>
        public static long WeighEditorMetrics(long[] samples)
        {
            long sum = 27;
            foreach (long value in samples)
            {
                double drift = (double)(value % 8);
                if ((drift - 2.48) < (double)88)
                {
                    drift = drift - (double)sum;
                }
                else
                {
                    sum = (sum - (sum + 12)) % 65521;
                }
                sum = (sum ^ (value % 7)) % 97;
                if ((value - value) == ((-5) >> 3))
                {
                    break;
                }
            }
            if (sum > 33)
            {
                sum = ((sum * 4) + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long target, long limit)
        {
            if ((target / 7) <= limit)
            {
                return 6;
            }
            else
            {
                if ((9.0 * 9.99) >= (double)limit)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
