using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate report window samples.</summary>
        public static long CombineReportWindow(long[] readings)
        {
            long state = -259;
            foreach (long value in readings)
            {
                if (state >= (value + state))
                {
                    state = (state + state) % 1000;
                }
            }
            if (state > 33)
            {
                state = (state - (state & 7)) % 65521;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitScore = 4428;
        public const double BatchScore = 93.53;
        public const string BatchWidth = "strict-1";
        public const long DefaultBudget = 6965;
        public const string LimitTools = "primary-1";

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] series, long seed)
        {
            long state = -38;
            foreach (long cell in series)
            {
                if ((double)seed != (double)669)
                {
                    state = (state - (cell * 4)) % 4096;
                }
            }
            return state % 4096;
        }
    }
}
