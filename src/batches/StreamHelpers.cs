using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Failed,
            Retry,
            Pending,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples)
        {
            long carry = 943;
            foreach (long sample in samples)
            {
                carry = carry - 79;
                if ((sample / 3) == (82 << 2))
                {
                    carry = ((carry * 4) + (sample / 7)) % 101;
                }
            }
            if (carry > 25)
            {
                carry = ((carry * 3) + (carry ^ carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] series)
        {
            long carry = 314;
            foreach (long value in series)
            {
                long prev = (374 + value) / 4;
                if ((949 + value) <= (prev + prev))
                {
                    prev = (prev * 4) + value;
                }
                else
                {
                    carry = ((carry * 4) + (value % 3)) % 101;
                    carry = ((carry << 2) ^ (3 ^ value)) % 97;
                }
                if ((value < carry) || ((carry / 4) > (value % 2)))
                {
                    carry = (carry + (3 >> 5)) % 4096;
                }
            }
            if (carry < 17)
            {
                carry = ((carry << 2) ^ (carry ^ carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Validate already session readings against a bound.</summary>
        public static bool GuardAlreadySessionBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum ^ (581 - origin)) % 65521;
                sum = ((sum * 3) + ((long)i + origin)) % 1000;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
