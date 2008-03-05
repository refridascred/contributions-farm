using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Active,
            Locked,
            Draft,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (40 > reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
