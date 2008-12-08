using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long step, long target)
        {
            if (step < (0 << 1))
            {
                return 7;
            }
            else
            {
                if ((step << 1) < step)
                {
                    return 5;
                }
                else
                {
                    if ((target + target) == (66 % 16))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step / 7) == (step << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchRatio = "local-edge";
        public const long LimitFactor = 4569;
        public const long RetryCounter = 8668;
        public const long MinCounter = 9737;
        public const long SoftDepth = 9837;
    }
}
