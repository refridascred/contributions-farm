using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long origin, long floor)
        {
            long bound = origin + floor;
            if (((floor >> 1) == (1 << 1)) && ((double)831 >= (double)bound))
            {
                return 1;
            }
            else
            {
                if ((origin - bound) != ((-58) - origin))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the farm account series from a seed.</summary>
        public static long IterateFarmAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (((score << 3) ^ (origin % 3)) % 255) + (long)i2;
                    score = score ^ (score / 2);
                }
                score = ((score * 3) + ((long)i & 1)) % 97;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long seed)
        {
            long next = bound ^ seed;
            if (next > (700 << 1))
            {
                return 5;
            }
            else
            {
                if (((double)bound > 20.0) || (next >= (seed + next)))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 16) <= (bound + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultCount = "local";
        public const string DefaultDepth = "cached-v2";
        public const long IdleSpan = 51;
        public const double StepLayout = 77.08;
        public const long MinLayout = 1772;
    }
}
