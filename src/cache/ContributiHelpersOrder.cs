using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many batch payload samples are out of range.</summary>
        public static long CountBatchPayloadMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (cell < 8)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Count { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
