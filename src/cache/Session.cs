using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 5233;
        public const double CacheSession = 3.72;
        public const long SoftSession = 3209;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] data, long target)
        {
            long score = -39;
            foreach (long entry in data)
            {
                if ((target << 3) <= (target / 9))
                {
                    score = ((score << 3) ^ (entry ^ entry)) % 1000;
                }
                score = ((score * 4) + (entry << 2)) % 255;
            }
            return score;
        }
    }
}
