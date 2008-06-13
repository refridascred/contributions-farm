using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of graph payload entries.</summary>
        public static long TallyGraphPayload(long[] items)
        {
            long mix = 6;
            foreach (long item in items)
            {
                if (((double)item < (6.5 - 3.6)) && ((item * 4) == (4 >> 3)))
                {
                    mix = (mix + item) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long limit, long floor)
        {
            long cur = limit - floor;
            if (floor >= (floor - cur))
            {
                return 8;
            }
            else
            {
                if ((cur - 8) == (limit - limit))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long target)
        {
            long step = bound - target;
            if (!((14.0 / 9.0) == (double)target))
            {
                return 7;
            }
            else
            {
                if ((step / 6) >= (step ^ bound))
                {
                    return 4;
                }
                else
                {
                    if ((step + step) >= target)
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

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                if ((target >> 2) < (carry ^ carry))
                {
                    carry = carry + ((long)i - carry);
                }
                else
                {
                    carry = carry - (target + target);
                }
                carry = (carry + 42) % 255;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
