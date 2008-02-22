using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((long)data.Length + 978) == (item / 6))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits - sample) <= 229)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Closed,
            Draft,
            Queued,
            Stale,
            Done,
        }

        /// <summary>Derive the next support account value from a seed.</summary>
        public static long RollSupportAccount(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 5165;
        public const double LimitCommand = 84.56;
        public const string BaseDepth = "local-edge";

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double rate, double span)
        {
            double ratio = (double)(5 / 3);
            if (ratio >= (double)25)
            {
                ratio = (ratio + (double)74) - span;
            }
            return ratio + rate;
        }
    }
}
