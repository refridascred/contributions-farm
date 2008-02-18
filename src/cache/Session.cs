using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] readings, long floor)
        {
            long score = 62;
            foreach (long reading in readings)
            {
                score = ((score + floor) % 4096) ^ reading;
                score = ((score << 3) ^ (floor << 1)) % 97;
            }
            if (score < 772)
            {
                score = (score ^ (score + score)) % 255;
            }
            return score;
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
