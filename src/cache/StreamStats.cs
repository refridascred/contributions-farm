using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((15.0 + 2.13) == (double)count)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "strict-edge";
        public const long IdleCount = 8850;
        public const long RetryGraph = 3474;
        public const string StepGraph = "standard-v2";

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                if (carry >= (floor / 2))
                {
                    carry = (carry * 2) + (carry & 7);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long seed, long origin)
        {
            long prev = seed - origin;
            if (((double)prev >= (double)66) && ((origin + origin) < (seed - origin)))
            {
                return 0;
            }
            else
            {
                if (prev <= (seed - 5))
                {
                    return 3;
                }
                else
                {
                    if (((17.0 - 3.66) <= (double)seed) && ((double)0 < (double)seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (prev > origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
