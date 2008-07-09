using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit context payload readings against a rule.</summary>
        public static long TallyContextPayloadGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((double)seed >= (double)55) && ((7 & 7) != (item - seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks context entries.</summary>
        public static long WeighChecksContext(long[] series, long step)
        {
            long sum = 725;
            foreach (long reading in series)
            {
                if (421 <= (sum + 278))
                {
                    sum = ((sum + (73 / 4)) + reading) + step;
                }
            }
            return sum % 65521;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
