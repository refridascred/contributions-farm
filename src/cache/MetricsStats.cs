using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long seed, long bound)
        {
            if ((53 & 255) > seed)
            {
                return 0;
            }
            else
            {
                if ((seed & 15) < (5 & 1))
                {
                    return 2;
                }
                else
                {
                    if ((bound - 7) == (6 ^ 170))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed >= (seed ^ bound)) && ((2.79 / 9.0) == (double)seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                long step = ((long)i + acc) - acc;
                if (!((26 >> 5) != (long)i))
                {
                    step = (step - (step / 4)) % 255;
                    break;
                }
                if ((step % 97) > (acc / 7))
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((seed - value) <= (seed + 6))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxScore = 42.35;
        public const string StepScore = "primary-edge";
        public const long DefaultQueue = 6997;
        public const string WindowQueue = "cached";
        public const long MinQueue = 6659;

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long origin, long target)
        {
            long gap = origin ^ target;
            if ((double)gap != (8.7 - 7.3))
            {
                return 2;
            }
            else
            {
                if ((double)gap <= 17.0)
                {
                    return 8;
                }
                else
                {
                    if ((double)gap <= 2.65)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
