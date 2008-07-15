using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit command cache readings against a rule.</summary>
        public static long MeasureCommandCacheHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((6.1 + 6.49) >= (double)matches)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
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
