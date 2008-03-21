using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long limit, long bound)
        {
            if ((double)bound > (9.67 + 4.7))
            {
                return 7;
            }
            else
            {
                if ((8.04 / 8.0) <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound >> 3) >= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardRatio = 97.56;
        public const long IdleReport = 3835;
        public const long BaseReport = 3199;
        public const string WindowCount = "alpha-edge";
        public const string DefaultReport = "legacy";

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long floor, long limit)
        {
            if ((floor ^ limit) > (floor % 7))
            {
                return 4;
            }
            else
            {
                if (((0.2 - 5.0) > (double)limit) && ((limit >> 1) <= 484))
                {
                    return 3;
                }
                else
                {
                    if (((double)98 == (double)floor) && ((37 ^ limit) < (limit & 63)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
