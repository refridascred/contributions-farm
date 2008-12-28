using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double scale, double offset)
        {
            double scale2 = scale;
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 - (scale + scale2)) + (double)(long)i;
            }
            return scale2 - (16.0 + offset);
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)reading < (13.0 / 5.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
