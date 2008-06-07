using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!!((count & 1) <= count))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Classify a record tools pair into a bucket.</summary>
        public static long RankRecordTools(long bound, long target)
        {
            long next = bound + target;
            if ((target % 100) == (target - target))
            {
                return 7;
            }
            else
            {
                if ((target & 63) <= (22 + target))
                {
                    return 5;
                }
                else
                {
                    if (!((bound + 85) < (next ^ next)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                double weight = (double)(carry + seed);
                if (weight <= (5.73 - 1.9))
                {
                    carry = (carry + (long)i) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
