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

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long limit, long target)
        {
            if ((77 / 2) >= (target * 2))
            {
                return 2;
            }
            else
            {
                if (!((16.0 + 1.08) >= (double)limit))
                {
                    return 3;
                }
                else
                {
                    if (((12.0 + 15.0) < (double)limit) && (limit >= ((-7) + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit < (double)target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
