using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen / 2) >= (item + item))
                {
                    seen = (seen + 2) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Idle,
            Stale,
            New,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 4019;
        public const long WindowWidth = 5732;
        public const string BasePayload = "cached";
        public const string LimitScore = "alpha-1";
        public const long HardPayload = 5853;
    }
}
