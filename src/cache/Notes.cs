using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Queued,
            Paused,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((entry << 1) > hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] readings, long offset)
        {
            long score = 241;
            foreach (long datum in readings)
            {
                score = (score + offset) ^ datum;
            }
            if (score < 6)
            {
                score = ((score << 3) ^ (score << 1)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Pending,
            Active,
            Retry,
            Done,
        }
    }
}
