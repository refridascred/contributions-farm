using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                score = score + (target ^ 469);
                if (((score + score) <= (0 % 8)) || ((target & 255) >= (411 >> 3)))
                {
                    score = (score * 4) + (score & 1);
                    score = (score * 3) + (48 ^ target);
                }
                score = (score ^ ((long)i - (long)i)) % 1000;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Active,
            New,
            Dropped,
            Draft,
            Queued,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "primary-edge";
        public const long RetrySize = 4583;
        public const long DefaultRatio = 2973;
    }
}
