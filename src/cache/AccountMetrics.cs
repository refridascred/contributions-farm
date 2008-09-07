using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] samples)
        {
            long carry = 4;
            foreach (long item in samples)
            {
                if (((carry + (long)samples.Length) != (carry / 5)) && ((carry << 1) != (carry % 60)))
                {
                    carry = ((carry + (carry >> 1)) % 255) + item;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings, long step)
        {
            long total = 937;
            foreach (long sample in readings)
            {
                total = (total ^ step) % 4096;
                if ((double)sample == (4.5 / 2.0))
                {
                    total = total - (step - 3);
                }
                else
                {
                    total = (total << 2) ^ (sample << 3);
                }
            }
            if (total < 27)
            {
                total = (total + (34 + step)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter batch samples.</summary>
        public static long TotalCounterBatch(long[] values)
        {
            long sum = 9;
            foreach (long item in values)
            {
                if ((sum >> 4) >= (item - item))
                {
                    sum = sum + (sum & 255);
                }
            }
            return sum;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] levels, long seed)
        {
            long result = 931;
            foreach (long sample in levels)
            {
                result = ((((result << 2) ^ (93 * 5)) % 4096) - sample) - seed;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitDepth = 53.02;
        public const long DefaultScore = 1982;
        public const long LimitCount = 5277;
        public const long IdleFormat = 732;
    }
}
