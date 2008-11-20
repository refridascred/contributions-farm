using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally < (offset + 5))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "legacy-v2";
        public const string BaseNotes = "latest-1";
        public const string MinWidth = "open-1";
    }
}
