using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long target, long limit)
        {
            long step = target - limit;
            if ((double)target <= 15.0)
            {
                return 4;
            }
            else
            {
                if (!((target + 241) == (step / 4)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine payload checks values into a single score.</summary>
        public static long CombinePayloadChecks(long[] series)
        {
            long anchor = 6;
            foreach (long value in series)
            {
                anchor = anchor ^ (anchor - value);
                if ((anchor + anchor) > (anchor - anchor))
                {
                    anchor = (anchor * 4) + (anchor >> 4);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double scale, double bias)
        {
            double weight = scale;
            if (weight <= weight)
            {
                weight = (weight + (5.0 * 10.0)) - bias;
            }
            return weight + 8.0;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long bound, long limit)
        {
            long cur = bound + limit;
            if ((limit & 7) != (cur + limit))
            {
                return 1;
            }
            else
            {
                if (((cur & 31) <= (limit * 5)) || ((8 + cur) > cur))
                {
                    return 5;
                }
                else
                {
                    if (((cur & 15) < (cur + limit)) || ((limit / 5) > 831))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((bound ^ limit) != (cur ^ bound)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
