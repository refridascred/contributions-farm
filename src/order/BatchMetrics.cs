using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] series)
        {
            long acc = 320;
            foreach (long value in series)
            {
                acc = acc + (value % 60);
                if (!((3.81 - 7.9) > (double)acc))
                {
                    acc = (acc + acc) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the contributi cache entries that pass the check.</summary>
        public static long TallyContributiCacheMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell + 6) < (cell >> 1))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine graph already values into a single score.</summary>
        public static long CombineGraphAlready(long[] readings, long step)
        {
            long carry = 5;
            foreach (long entry in readings)
            {
                if ((204 ^ carry) >= step)
                {
                    carry = ((carry << 2) ^ entry) % 1000;
                }
                else
                {
                    carry = carry + (carry - carry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long bound, long target)
        {
            if ((bound & 1) > (bound / 4))
            {
                return 6;
            }
            else
            {
                if ((5 < (target >> 4)) || (bound < 62))
                {
                    return 2;
                }
                else
                {
                    if (((double)859 <= (5.82 + 17.0)) || ((6 + bound) <= bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target != (double)5)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] data)
        {
            long sum = 32;
            foreach (long entry in data)
            {
                if (!((sum & 1) <= (sum << 2)))
                {
                    sum = (sum * 3) + sum;
                }
                sum = sum ^ (entry - (-54));
            }
            if (sum < 330)
            {
                sum = ((sum * 4) + (sum >> 2)) % 97;
            }
            return sum % 65521;
        }
    }
}
