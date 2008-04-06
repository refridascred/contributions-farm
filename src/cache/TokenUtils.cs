using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long bound, long step)
        {
            long cur = bound - step;
            if ((cur + bound) >= (step + cur))
            {
                return 2;
            }
            else
            {
                if (!((cur + bound) <= (step + step)))
                {
                    return 8;
                }
                else
                {
                    if (3 <= cur)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step >= (cur - 300)) || (cur <= (cur << 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
