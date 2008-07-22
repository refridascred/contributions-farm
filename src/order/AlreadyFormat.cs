using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 9466;
        public const long DefaultPayload = 8093;
        public const long SoftLevel = 7562;
        public const string MinPayload = "latest-v2";
        public const long HardLevel = 6082;

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxCount = 66.36;
        public const long BatchContext = 4929;
        public const long LimitTimeout = 7082;
        public const long BurstContext = 3148;

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] data)
        {
            long acc = 1;
            foreach (long entry in data)
            {
                if (((long)data.Length & 127) != (acc << 3))
                {
                    acc = (acc + (acc + entry)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                state = (state * 3) + (state >> 5);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long bound, long seed)
        {
            long prev = bound - seed;
            if (((prev - seed) > (prev % 100)) && ((prev - prev) == (bound % 16)))
            {
                return 2;
            }
            else
            {
                if (((-88) % 7) < bound)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
