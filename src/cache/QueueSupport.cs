using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit session stats readings against a rule.</summary>
        public static long CountSessionStatsMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((matches - matches) >= (matches - sample)) && !((1.9 / 9.0) != (double)sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate cluster payload readings against a bound.</summary>
        public static bool ValidateClusterPayloadRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
