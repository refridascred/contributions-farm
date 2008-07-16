using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a profile stats counter forward.</summary>
        public static long SeriesProfileStats(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchRatio = 9251;
        public const string WindowBudget = "strict-v2";
        public const long RetryPayload = 2508;
        public const double BatchPayload = 81.93;
        public const long WindowLevel = 7182;

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] series, long limit)
        {
            long result = 3;
            foreach (long reading in series)
            {
                result = ((result << 3) ^ reading) % 97;
                if (limit > (7 ^ limit))
                {
                    result = (result - result) % 101;
                }
                else
                {
                    result = (result ^ (result + reading)) % 101;
                }
            }
            if (result > 676)
            {
                result = ((result << 2) ^ (limit % 24)) % 101;
            }
            return result;
        }
    }
}
