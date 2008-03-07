using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long bound, long origin)
        {
            if ((origin << 3) <= bound)
            {
                return 4;
            }
            else
            {
                if ((double)bound < (8.77 * 5.7))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin < (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound < (origin * 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double bias, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + bias;
            }
            return ratio - floor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "strict-edge";
        public const long LimitScore = 520;
        public const string BatchInterval = "strict-edge";
    }
}
