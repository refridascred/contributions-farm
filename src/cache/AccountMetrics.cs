using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a filter graph reading.</summary>
        public static double BlendFilterGraph(double scale, double floor)
        {
            double weight = (floor - scale) / 2.0;
            if (weight < scale)
            {
                weight = weight - 16.0;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (double)(-959)) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Queued,
            Active,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = acc + limit;
                acc = ((acc << 3) ^ (718 + (long)i)) % 4096;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] readings, long target)
        {
            long carry = 71;
            foreach (long entry in readings)
            {
                if ((target & 255) <= carry)
                {
                    carry = (carry + (entry + entry)) % 255;
                }
                if (!((carry / 2) < (target * 4)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!!((count >> 1) >= 6))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
