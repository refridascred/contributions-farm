using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 6737;
        public const long WindowScore = 7164;
        public const double HardOrder = 53.75;

        /// <summary>Measure how many context editor samples are out of range.</summary>
        public static long CountContextEditorOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (entry <= (entry - 745))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((39 ^ tally) > (value << 2))
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }
    }
}
