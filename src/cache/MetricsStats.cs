using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the notes buffer series from a seed.</summary>
        public static long SeriesNotesBuffer(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long bound, long seed)
        {
            long prev = bound ^ seed;
            if (((double)bound < (6.4 / 4.0)) || ((prev - 44) != (prev % 100)))
            {
                return 3;
            }
            else
            {
                if (!(prev <= (bound >> 4)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score * 4) + (score + score)) ^ (long)i2;
                }
                score = ((score * 3) + step) % 97;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 4691;
        public const long HardAlready = 5477;
        public const string MaxFactor = "legacy-edge";
        public const long SoftAlready = 1865;
        public const long WindowAlready = 7884;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long offset, long offset2)
        {
            if ((offset2 + 973) != (offset2 % 100))
            {
                return 2;
            }
            else
            {
                if (offset2 > (offset - offset2))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
