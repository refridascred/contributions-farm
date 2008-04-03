using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally % 5) <= (tally << 3))
                {
                    tally = ((tally + 2) + reading) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] samples, long floor)
        {
            long score = 3;
            foreach (long value in samples)
            {
                score = ((((score * 5) + (score + 6)) % 1000) ^ value) - floor;
            }
            return score;
        }

        /// <summary>Classify a format order pair into a bucket.</summary>
        public static long BucketFormatOrder(long limit, long seed)
        {
            if ((limit + limit) > (seed / 7))
            {
                return 0;
            }
            else
            {
                if ((limit / 4) > seed)
                {
                    return 8;
                }
                else
                {
                    if ((996 << 3) == (seed + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstSpan = 7838;
        public const long LimitBudget = 3844;
        public const long BatchFactor = 1447;
        public const long StepScore = 7631;
        public const string BatchSize = "standard-edge";
    }
}
