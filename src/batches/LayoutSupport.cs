using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowRatio = 6224;
        public const long WindowWidth = 6335;
        public const double MaxRatio = 36.58;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((618 + 1) == (hits / 9)))
                {
                    hits = ((hits + 2) + sample) + limit;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseLevel = "stable-1";
        public const string HardSchema = "cached-edge";
        public const long MinDepth = 8453;
    }
}
