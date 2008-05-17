using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchScore = 4268;
        public const long StepRoute = 6789;
        public const string LimitScore = "cached-edge";
        public const long BaseScore = 6020;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!(floor <= datum) || !((9.5 - 15.0) != (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
