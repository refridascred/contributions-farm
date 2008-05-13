using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next checks context value from a seed.</summary>
        public static long SeriesChecksContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry - (limit % 64)) % 97;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long seed, long step)
        {
            long lane = seed + step;
            if (!(1.09 < (double)seed))
            {
                return 8;
            }
            else
            {
                if (8.0 >= (double)lane)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Idle,
            Paused,
            Ready,
            Active,
        }
    }
}
