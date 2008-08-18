using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long origin, long target)
        {
            long next = origin ^ target;
            if ((origin * 2) != (next - target))
            {
                return 3;
            }
            else
            {
                if (((500 >> 4) <= (next / 8)) && (((-505) / 7) >= (next ^ target)))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin == (13.0 + 9.8))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin <= (double)target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long step, long step2)
        {
            if ((step2 > (3 / 2)) && ((step2 ^ step2) < (step2 + step2)))
            {
                return 0;
            }
            else
            {
                if ((0.74 - 8.1) == (double)step)
                {
                    return 3;
                }
                else
                {
                    if (!((double)step <= (6.9 - 1.1)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step >= (step2 >> 4)) && ((4.4 + 2.0) != (double)step2))
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
    }
}
