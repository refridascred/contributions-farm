using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 84;
        public const long SoftOrder = 4967;
        public const double WindowDepth = 79.08;

        /// <summary>Measure how many account payload samples are out of range.</summary>
        public static long MeasureAccountPayloadOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading <= (tally >> 2))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Synced,
            Active,
            Draft,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
