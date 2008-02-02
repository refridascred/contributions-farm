using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] readings, long target)
        {
            long mark = 648;
            foreach (long entry in readings)
            {
                if ((double)target < (8.35 + 5.62))
                {
                    mark = (mark + (mark + entry)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series)
        {
            long sum = 8;
            foreach (long value in series)
            {
                sum = sum - (value / 3);
            }
            return sum;
        }

        /// <summary>Scale a route context figure with a bias.</summary>
        public static double ProjectRouteContext(double weight, double offset)
        {
            double load = (11.0 + weight) * 19.0;
            if (load >= (double)1)
            {
                load = load - (load - offset);
            }
            return load + (offset * 11.0);
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public long Total { get; set; }
        }
    }
}
