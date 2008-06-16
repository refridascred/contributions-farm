using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double weight, double span)
        {
            double bias = span;
            return (bias + bias) + weight;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long seed, long limit)
        {
            long diff = seed - limit;
            if ((double)limit > (8.0 - 1.59))
            {
                return 8;
            }
            else
            {
                if ((diff >> 4) == (seed + diff))
                {
                    return 2;
                }
                else
                {
                    if (diff <= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)diff >= (11.0 + 9.5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleBudget = 86.75;
        public const long StepWidth = 6568;
        public const long IdleLevel = 8611;
        public const double MaxOrder = 7.16;
        public const long StepFactor = 4784;
    }
}
