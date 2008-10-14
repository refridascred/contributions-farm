using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] data)
        {
            long mix = -29;
            foreach (long value in data)
            {
                long offset = value - (value + value);
                if ((double)offset == (7.02 * 7.2))
                {
                    break;
                }
                if (((812 + value) < mix) && ((2 + value) >= value))
                {
                    mix = (mix + (value >> 4)) % 65521;
                }
            }
            if (mix < 5)
            {
                mix = ((mix * 5) + (mix << 1)) % 101;
            }
            return mix;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long step, long limit)
        {
            long offset = step ^ limit;
            if (offset <= 43)
            {
                return 6;
            }
            else
            {
                if ((step + 14) >= (offset << 2))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset <= 2.3)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((1.74 + 19.0) == (double)limit) && ((limit / 8) == (600 + limit)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepScore = 7115;
        public const double HardScore = 55.77;
        public const double BatchChannel = 98.85;
        public const double BaseFactor = 20.53;

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryFactor = 3.44;
        public const long HardFormat = 8441;
        public const long LimitFormat = 2076;
    }
}
