using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] readings, long step)
        {
            long carry = 4;
            foreach (long item in readings)
            {
                if ((carry << 1) <= step)
                {
                    carry = ((carry << 2) ^ (step + carry)) % 4096;
                }
                else
                {
                    carry = (carry + item) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Grade a stats command value against two limits.</summary>
        public static long GradeStatsCommand(long limit, long floor)
        {
            if ((floor + floor) > (floor - 364))
            {
                return 8;
            }
            else
            {
                if ((limit >= (-9)) && ((limit / 8) < (56 >> 1)))
                {
                    return 1;
                }
                else
                {
                    if ((limit >> 4) <= (floor / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Idle,
            Dropped,
            Retry,
        }
    }
}
