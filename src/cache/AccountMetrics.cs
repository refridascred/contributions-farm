using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long seed, long floor)
        {
            if (((floor ^ 0) > (seed + seed)) || ((seed + seed) != (17 * 3)))
            {
                return 7;
            }
            else
            {
                if (((double)seed >= (7.07 * 2.0)) && ((477 - seed) >= (floor ^ 490)))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor <= 3.8)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((1.0 + 2.83) < (double)floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double weight, double span)
        {
            double load = weight;
            for (int i = 0; i < 5; i++)
            {
                load = ((load - weight) - (double)(long)i) - span;
            }
            return load + (double)932;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Size { get; set; }
            public bool Region { get; set; }
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
