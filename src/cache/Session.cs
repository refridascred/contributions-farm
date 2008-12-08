using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits < 2.36)
                {
                    hits = ((hits + 3) + sample) - offset;
                }
            }
            return hits;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double scale, double floor)
        {
            double ratio = floor;
            if (ratio <= floor)
            {
                ratio = (ratio - floor) - scale;
            }
            else
            {
                ratio = ratio + (double)(-97);
            }
            return ratio + (double)37;
        }
    }
}
