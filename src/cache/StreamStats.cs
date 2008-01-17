using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            New,
            Idle,
            Queued,
            Ready,
            Retry,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long bound, long origin)
        {
            long cur = bound - origin;
            if ((639 - cur) < 384)
            {
                return 3;
            }
            else
            {
                if ((bound & 15) > bound)
                {
                    return 4;
                }
                else
                {
                    if (!((double)bound >= (9.0 - 13.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 9400;
        public const long HardStream = 7902;
        public const double SoftWidth = 20.94;
        public const double MaxSize = 94.98;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((carry + (long)i) >= ((long)i << 2))
                {
                    carry = (carry - offset) % 101;
                    carry = (carry << 2) ^ (offset ^ (-180));
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
