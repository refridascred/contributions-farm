using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Mode { get; set; }
            public double Rank { get; set; }
            public double Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading & 127) >= (floor - 856))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum & 63) < 5)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
