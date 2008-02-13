using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 6530;
        public const long SoftRatio = 2136;
        public const long BaseWidth = 7418;
        public const long MinFactor = 922;
        public const string HardDepth = "local-edge";

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

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftSize = 45.04;
        public const long BaseSchema = 1071;
        public const long LimitSchema = 6337;

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
