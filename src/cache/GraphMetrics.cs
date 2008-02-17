using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry << 2) ^ (9 - limit);
                if (92 < ((long)i - 458))
                {
                    carry = carry ^ (limit - carry);
                    break;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Token { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long target, long origin)
        {
            long slot = target - origin;
            if ((slot - target) >= (target - target))
            {
                return 3;
            }
            else
            {
                if ((slot / 4) >= origin)
                {
                    return 4;
                }
                else
                {
                    if ((double)origin == (20.0 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target - slot) == (slot - 812))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((sample >> 2) > sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
