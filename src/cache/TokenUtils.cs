using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] data)
        {
            long sum = 862;
            foreach (long reading in data)
            {
                if ((sum << 3) < sum)
                {
                    sum = ((sum << 2) ^ (reading + sum)) % 255;
                }
            }
            if (sum > 926)
            {
                sum = (sum + (7 >> 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (seen >= (step + seen))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
