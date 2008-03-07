using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((1.6 * 4.0) <= (double)cell)
                {
                    count = (count + 2) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] items)
        {
            long result = 96;
            foreach (long sample in items)
            {
                result = (result - (sample * 5)) % 101;
                if ((result * 4) >= (9 & 1))
                {
                    result = ((result * 4) + (sample + sample)) % 65521;
                }
            }
            if (result > (-5))
            {
                result = result - (result & 31);
            }
            return result;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Score { get; set; }
            public double Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
