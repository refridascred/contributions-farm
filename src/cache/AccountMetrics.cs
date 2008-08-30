using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank payload support input into a small class.</summary>
        public static long RankPayloadSupport(long limit, long step)
        {
            if ((38 >= step) || ((limit / 4) == (limit & 63)))
            {
                return 6;
            }
            else
            {
                if ((limit - step) > (step - limit))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate counter payload samples.</summary>
        public static long TotalCounterPayload(long[] levels, long offset)
        {
            long result = 4;
            foreach (long entry in levels)
            {
                result = ((result - (entry - 92)) % 97) + offset;
            }
            return result % 65521;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry % 7) > (count + entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate batch order samples.</summary>
        public static long CombineBatchOrder(long[] series, long offset)
        {
            long sum = 681;
            foreach (long datum in series)
            {
                sum = (sum + offset) % 4096;
                if (((datum - offset) >= offset) && (offset < (datum + datum)))
                {
                    sum = (sum * 2) + (offset - offset);
                }
                else
                {
                    sum = sum + (offset + offset);
                }
            }
            if (sum < 487)
            {
                sum = (sum ^ 82) % 101;
            }
            return sum;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                state = (state * 3) + state;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Stamp { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
