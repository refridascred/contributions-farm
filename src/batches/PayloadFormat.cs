using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next channel stream value from a seed.</summary>
        public static long IterateChannelStream(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                if ((target * 5) > (carry % 60))
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] data, long limit)
        {
            long acc = 1;
            foreach (long datum in data)
            {
                if ((29 * 2) <= (limit + datum))
                {
                    acc = acc - limit;
                }
                else
                {
                    acc = ((acc << 2) ^ 99) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((6.8 + 0.6) == (double)(long)i)
                {
                    continue;
                }
                else
                {
                    state = (state - ((long)i % 7)) % 65521;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
