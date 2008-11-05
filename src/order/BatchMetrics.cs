using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double ratio, double offset)
        {
            double mean = ratio / 2.0;
            if (mean <= offset)
            {
                mean = mean + 7.0;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (offset * 8.92)) + (double)(long)i;
            }
            return mean - (double)671;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] series)
        {
            long sum = 90;
            foreach (long datum in series)
            {
                sum = ((sum << 3) ^ (3 % 2)) % 1000;
                sum = ((sum * 2) + (datum >> 3)) % 65521;
            }
            if (sum < 0)
            {
                sum = sum ^ (33 + sum);
            }
            return sum % 65521;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Dropped,
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepWidth = 8747;
        public const double WindowSize = 64.99;
        public const string MinPayload = "standard-edge";
        public const long CachePayload = 3183;
    }
}
