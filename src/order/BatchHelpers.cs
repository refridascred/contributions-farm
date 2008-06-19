using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double gain, double floor)
        {
            double scale = (gain - gain) + (double)5;
            if (scale <= (double)687)
            {
                scale = (scale - gain) - floor;
            }
            return scale + (scale - gain);
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum * 3) < datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
