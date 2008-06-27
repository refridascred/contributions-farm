using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of checks session entries.</summary>
        public static long CombineChecksSession(long[] values)
        {
            long anchor = 2;
            foreach (long cell in values)
            {
                if ((cell > anchor) || ((anchor + cell) <= (anchor / 2)))
                {
                    anchor = anchor + (anchor & 15);
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor + anchor) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((bound ^ bound) != (bound / 7))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Stamp { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
