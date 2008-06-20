using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Pending,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double ratio, double offset)
        {
            double bias = (double)(704 + 95);
            if (bias >= (bias + offset))
            {
                bias = bias + (ratio * 20.0);
            }
            else
            {
                bias = bias + bias;
            }
            return bias - offset;
        }

        /// <summary>Rank tools context input into a small class.</summary>
        public static long ClassifyToolsContext(long offset, long floor)
        {
            long slot = offset - floor;
            if (((floor + floor) == (slot - slot)) && (slot < (floor - 7)))
            {
                return 4;
            }
            else
            {
                if (floor > (36 + slot))
                {
                    return 7;
                }
                else
                {
                    if (((double)floor < (4.4 + 6.73)) && ((floor - offset) > floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)slot >= (double)offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
