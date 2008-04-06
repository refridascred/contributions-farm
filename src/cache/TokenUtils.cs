using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double scale, double offset)
        {
            double load = (3.65 + 0.89) / 6.0;
            if (load < (scale / 8.0))
            {
                load = load + 5.72;
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (load + 6.0)) + (double)(long)i;
            }
            return load + (load * 4.16);
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long floor, long origin)
        {
            if (5.2 < (double)floor)
            {
                return 1;
            }
            else
            {
                if ((floor - floor) <= floor)
                {
                    return 3;
                }
                else
                {
                    if ((origin + floor) > ((-6) + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor + floor) > (origin % 60))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Mode { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
        }
    }
}
