using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "open-1";
        public const string HardBatch = "primary-v2";
        public const long DefaultBatch = 5833;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long step, long floor)
        {
            if ((step & 255) >= (step + step))
            {
                return 7;
            }
            else
            {
                if (floor >= (floor + 0))
                {
                    return 3;
                }
                else
                {
                    if ((double)step != (double)509)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-992) >> 2) < (floor + step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double ratio, double bias)
        {
            double weight = bias;
            if (weight > (double)6)
            {
                weight = weight - 18.0;
            }
            else
            {
                weight = weight + 20.0;
            }
            return weight - ratio;
        }

        /// <summary>Combine account payload values into a single score.</summary>
        public static long TotalAccountPayload(long[] samples)
        {
            long anchor = 845;
            foreach (long value in samples)
            {
                anchor = anchor ^ (anchor - value);
                if (((8.53 - 4.5) < (double)78) && ((double)value == (5.5 * 1.0)))
                {
                    anchor = anchor + (value % 60);
                }
            }
            return anchor;
        }
    }
}
