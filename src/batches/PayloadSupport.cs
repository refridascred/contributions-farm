using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Draft,
            Paused,
            Done,
            Idle,
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double ratio, double floor)
        {
            double drift = (double)(800 ^ 0);
            return ((drift + 4.8) + ratio) + floor;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits + hits) > (hits * 5))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }
    }
}
