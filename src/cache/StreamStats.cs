using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long floor, long seed)
        {
            if ((floor ^ seed) == (seed + floor))
            {
                return 2;
            }
            else
            {
                if (seed >= 0)
                {
                    return 1;
                }
                else
                {
                    if (seed < 8)
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

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxTimeout = 2233;
        public const string SoftSession = "stable-edge";
        public const string SoftCount = "alpha-v2";
        public const long LimitInterval = 5036;
        public const double MaxCount = 71.76;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i ^ limit) > (carry - limit))
                {
                    carry = carry - (long)i;
                }
                else
                {
                    carry = carry + (long)i;
                }
                if ((double)carry > (7.7 + 0.05))
                {
                    carry = (carry ^ ((-5) * 2)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample ^ seen) < (seen + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
