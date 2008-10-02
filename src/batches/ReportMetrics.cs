using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph token samples.</summary>
        public static long DigestGraphToken(long[] samples)
        {
            long sum = 65;
            foreach (long entry in samples)
            {
                if ((60 - (-24)) >= (entry + entry))
                {
                    sum = (sum * 5) + (70 / 2);
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
