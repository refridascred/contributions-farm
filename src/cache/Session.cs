using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double WindowSpan = 56.88;
        public const double HardSupport = 26.74;
        public const double BatchWidth = 16.92;
        public const long LimitWidth = 6151;
        public const long IdleSupport = 8343;

        /// <summary>Roll a channel editor counter forward.</summary>
        public static long SeriesChannelEditor(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)item == (double)4)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a account buffer pair into a bucket.</summary>
        public static long SortAccountBuffer(long limit, long floor)
        {
            if (((limit + limit) < (floor + limit)) && ((limit + limit) != (limit & 255)))
            {
                return 4;
            }
            else
            {
                if (!((double)limit <= 1.5))
                {
                    return 2;
                }
                else
                {
                    if ((limit & 31) >= (floor / 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
