using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long offset, long floor)
        {
            long offset2 = offset + floor;
            if ((floor - offset) > (offset2 << 2))
            {
                return 6;
            }
            else
            {
                if (((floor >> 1) != (offset + floor)) || (offset2 >= (offset - offset)))
                {
                    return 7;
                }
                else
                {
                    if (!((815 >> 1) >= offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((17.0 + 1.61) >= (4.0 - 11.0)) || ((floor >> 5) > (offset / 5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double gain, double bias)
        {
            double scale = (gain + 6.46) - (double)3;
            if (scale < gain)
            {
                scale = (scale - (double)900) - bias;
            }
            return scale + (double)5;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Stale,
            Dropped,
            Pending,
            Active,
            Idle,
        }
    }
}
