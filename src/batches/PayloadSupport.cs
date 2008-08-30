using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value - limit) > (value + limit))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Retry,
            Pending,
            New,
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double rate, double floor)
        {
            double bias = (double)4 - (rate * 2.0);
            return (bias - (double)7) + floor;
        }
    }
}
