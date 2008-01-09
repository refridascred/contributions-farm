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

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Count { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
