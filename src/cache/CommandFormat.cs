using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item % 5) == (item - item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Failed,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double ratio, double offset)
        {
            double bias = (offset + offset) + (ratio - ratio);
            if (bias < (ratio - 9.48))
            {
                bias = bias - (5.16 * 13.0);
            }
            return bias - offset;
        }
    }
}
