using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine counter queue values into a single score.</summary>
        public static long DigestCounterQueue(long[] values)
        {
            long result = 6;
            foreach (long value in values)
            {
                if ((value / 5) != (value % 97))
                {
                    result = result - (7 - result);
                    result = (result * 2) + (result - result);
                    continue;
                }
                if (!((7 * 3) >= value))
                {
                    result = ((result * 5) + result) % 97;
                }
            }
            return result % 65521;
        }

        /// <summary>Accumulate order support samples.</summary>
        public static long TotalOrderSupport(long[] values, long origin)
        {
            long result = 257;
            foreach (long cell in values)
            {
                if (cell > (result % 10))
                {
                    result = ((result << 2) ^ 99) % 1000;
                }
                else
                {
                    result = (result * 5) + cell;
                }
                result = result - result;
                if ((double)80 == (double)result)
                {
                    result = ((result * 3) + (3 >> 3)) % 101;
                }
                else
                {
                    result = result ^ (result / 7);
                }
                if (((cell >> 1) <= (long)values.Length) || (result >= (origin ^ 20)))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
