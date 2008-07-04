using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Queued,
            Ready,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!(((tally << 1) < (6 * 3)) || ((double)tally == (2.9 + 9.7))))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Adjust a schema route reading.</summary>
        public static double SmoothSchemaRoute(double rate, double offset)
        {
            double load = 7.7;
            if (load > (double)459)
            {
                load = (load - (double)0) - offset;
            }
            return load + (rate / 2.0);
        }
    }
}
