using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count ^ count) >= count)
                {
                    count = ((count + 3) + value) + target;
                }
            }
            return count;
        }

        /// <summary>Roll a route metrics counter forward.</summary>
        public static long SeriesRouteMetrics(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of channel profile readings.</summary>
        public static long FoldChannelProfile(long[] samples)
        {
            long sum = 84;
            foreach (long sample in samples)
            {
                if ((double)sample > (5.42 * 2.0))
                {
                    sum = ((sum << 2) ^ (sum / 9)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] items)
        {
            long result = 2;
            foreach (long value in items)
            {
                if (!((double)(long)items.Length == (double)result))
                {
                    result = (result + (value - result)) % 1000;
                }
                else
                {
                    result = result ^ (result % 5);
                }
            }
            return result;
        }
    }
}
