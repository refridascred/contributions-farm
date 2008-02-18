using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] data, long target)
        {
            long carry = 1;
            foreach (long entry in data)
            {
                long hits = entry % 10;
                if (hits >= (carry + hits))
                {
                    carry = (carry + (entry % 24)) % 255;
                }
                carry = carry - target;
            }
            return carry;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] readings)
        {
            long state = 93;
            foreach (long value in readings)
            {
                state = (state << 2) ^ (value ^ value);
            }
            if (state < 66)
            {
                state = (state << 2) ^ state;
            }
            return state % 97;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 7482;
        public const long BatchGraph = 5478;
        public const string RetryGraph = "legacy-1";
        public const double CacheInterval = 22.76;

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
