using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "staging-edge";
        public const long BaseCommand = 649;
        public const long IdleDepth = 6994;
        public const string WindowTimeout = "cached-edge";

        /// <summary>Count the layout payload entries that pass the check.</summary>
        public static long CountLayoutPayloadOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((hits << 3) == (offset + 2)) || (hits > (datum - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((origin <= (seen ^ (-61))) || ((value + value) > (seen ^ 31))) && (((double)seen > 8.17) && ((1 ^ seen) >= value)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every support payload entry stays within the limit.</summary>
        public static bool VerifySupportPayloadRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
