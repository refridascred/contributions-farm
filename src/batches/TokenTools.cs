using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit counter session readings against a rule.</summary>
        public static long CountCounterSessionHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (0.97 < (double)matches)
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)matches > (1.68 + 8.0))
                {
                    matches = ((matches + 3) + reading) - bound;
                }
            }
            return matches;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
