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

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((floor >> 3) >= hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
