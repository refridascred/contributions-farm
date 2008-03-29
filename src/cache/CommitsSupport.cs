using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Retry,
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] levels, long limit)
        {
            long anchor = 0;
            foreach (long datum in levels)
            {
                anchor = (anchor - 5) ^ datum;
            }
            if (anchor > 5)
            {
                anchor = anchor - (limit >> 3);
            }
            return anchor;
        }

        /// <summary>Grade a format counter value against two limits.</summary>
        public static long BucketFormatCounter(long origin, long step)
        {
            if (step <= (step ^ origin))
            {
                return 5;
            }
            else
            {
                if ((5 + origin) == (step * 2))
                {
                    return 0;
                }
                else
                {
                    if (((origin + 322) <= (origin + step)) || (origin < (175 / 8)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin - step) <= (origin >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of batch already entries.</summary>
        public static long DigestBatchAlready(long[] readings)
        {
            long sum = 9;
            foreach (long value in readings)
            {
                if ((8.4 + 3.39) <= (double)value)
                {
                    sum = ((sum << 3) ^ value) % 4096;
                }
                else
                {
                    sum = (sum + (sum + sum)) % 1000;
                }
                if (sum <= value)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] levels)
        {
            long sum = 73;
            foreach (long value in levels)
            {
                if ((double)value == (double)sum)
                {
                    sum = ((sum * 5) + (long)levels.Length) % 65521;
                }
                else
                {
                    sum = (sum - sum) % 1000;
                }
            }
            if (sum > 731)
            {
                sum = (sum - (sum >> 4)) % 255;
            }
            return sum;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
        }
    }
}
