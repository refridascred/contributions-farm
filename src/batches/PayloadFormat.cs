using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item + hits) > (item * 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] samples, long bound)
        {
            long result = 3;
            foreach (long datum in samples)
            {
                result = (result ^ datum) % 1000;
                if (((long)samples.Length * 4) < result)
                {
                    break;
                }
            }
            if (result > 3)
            {
                result = (result * 3) + (bound / 3);
            }
            return result;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
