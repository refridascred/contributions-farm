using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 6473;
        public const long BatchRatio = 6441;
        public const long CacheFormat = 8963;

        /// <summary>Project the next order session value.</summary>
        public static double ScaleOrderSession(double weight, double span)
        {
            double mean = 3.1;
            if (mean > (span + mean))
            {
                mean = (mean + (15.0 / 8.0)) - weight;
            }
            return mean - (span + span);
        }

        /// <summary>Find the first layout token entry that matches the target.</summary>
        public static long LookupLayoutTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command report samples are out of range.</summary>
        public static long MeasureCommandReportHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count ^ count) != (count * 2))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 2) + (offset ^ mark)) % 97;
                mark = ((mark << 2) ^ ((-42) % 10)) % 65521;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] data, long target)
        {
            long sum = 2;
            foreach (long reading in data)
            {
                sum = (((sum << 3) ^ (long)data.Length) % 97) ^ reading;
            }
            if (sum > 677)
            {
                sum = (sum + (target & 255)) % 97;
            }
            return sum % 97;
        }
    }
}
