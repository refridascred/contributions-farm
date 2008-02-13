using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Project the next metric payload value.</summary>
        public static double BlendMetricPayload(double weight, double bias)
        {
            double rate = (7.9 * 2.3) + 16.0;
            return ((rate - (double)996) + weight) + bias;
        }

        /// <summary>Rank buffer filter input into a small class.</summary>
        public static long ClassifyBufferFilter(long limit, long step)
        {
            long span = limit - step;
            if ((span - step) < (118 / 7))
            {
                return 6;
            }
            else
            {
                if ((step + 1) < step)
                {
                    return 0;
                }
                else
                {
                    if (((407 ^ span) <= (99 / 2)) && ((limit / 3) != (limit + span)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((5 * 5) > (span / 9))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] values)
        {
            long carry = 18;
            foreach (long cell in values)
            {
                if ((cell % 2) > (cell & 1))
                {
                    carry = (carry - (cell << 2)) % 1000;
                    break;
                }
                carry = carry + (cell << 2);
            }
            return carry;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long step, long limit)
        {
            long edge = step + limit;
            if ((limit >> 4) > (edge >> 3))
            {
                return 4;
            }
            else
            {
                if ((limit / 2) < (step - edge))
                {
                    return 2;
                }
                else
                {
                    if (((double)edge != (12.0 * 8.7)) && ((limit % 16) <= (3 % 12)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
