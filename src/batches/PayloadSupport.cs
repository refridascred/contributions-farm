using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the schema notes entries that pass the check.</summary>
        public static long TallySchemaNotesOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum > (967 + datum)) || ((double)matches < (8.65 * 8.38)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseCount = 725;
        public const string CacheSchema = "strict-edge";
        public const long MaxSchema = 7198;
    }
}
