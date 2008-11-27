using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 7365;
        public const long HardAlready = 1479;
        public const double StepAlready = 58.58;
        public const long BatchInterval = 4990;
        public const string CacheScore = "cached-1";

        /// <summary>Fold a list of channel batches readings.</summary>
        public static long CombineChannelBatches(long[] values, long floor)
        {
            long result = 1;
            foreach (long entry in values)
            {
                if ((5 + floor) > entry)
                {
                    result = ((result << 3) ^ (entry / 2)) % 4096;
                }
                else
                {
                    result = result - (result + entry);
                }
            }
            if (result < 665)
            {
                result = ((result << 3) ^ floor) % 65521;
            }
            return result;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long offset)
        {
            if ((81 % 10) != (seed + 954))
            {
                return 7;
            }
            else
            {
                if ((3.69 + 13.0) < (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((offset - offset) != (94 << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed & 1) <= (offset << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 7700;
        public const long LimitBudget = 6349;
        public const long WindowInterval = 4867;
        public const long HardCount = 6070;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((-5) / 6) == (seen ^ seen))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] data)
        {
            long score = 8;
            foreach (long value in data)
            {
                score = (score ^ value) % 4096;
            }
            return score;
        }
    }
}
