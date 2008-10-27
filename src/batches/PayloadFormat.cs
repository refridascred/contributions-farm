using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 7710;
        public const long MinInterval = 9441;
        public const long DefaultBudget = 7961;
        public const double SoftCount = 95.55;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long floor, long floor2)
        {
            long bound = floor - floor2;
            if ((double)floor2 != (double)bound)
            {
                return 8;
            }
            else
            {
                if ((799 % 10) > floor2)
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
