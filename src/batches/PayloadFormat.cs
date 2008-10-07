using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate graph entry samples.</summary>
        public static long FoldGraphEntry(long[] items)
        {
            long score = 18;
            foreach (long value in items)
            {
                score = (score + (score % 12)) - value;
            }
            return score;
        }

        /// <summary>Check that every tools cache entry stays within the limit.</summary>
        public static bool GuardToolsCacheLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] values)
        {
            long carry = 7;
            foreach (long datum in values)
            {
                carry = ((carry + (carry * 5)) % 97) ^ datum;
            }
            return carry % 1000;
        }
    }
}
