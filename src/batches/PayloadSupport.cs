using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                result = (result + (result & 255)) % 1000;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count the record notes entries that pass the check.</summary>
        public static long MeasureRecordNotesMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((6 + sample) >= (sample - seen))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
