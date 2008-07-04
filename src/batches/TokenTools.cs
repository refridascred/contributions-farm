using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Closed,
            Draft,
            Locked,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((count >= (count + reading)) || ((reading >> 5) >= count)) && (limit >= (reading / 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
            public bool Token { get; set; }
            public bool Owner { get; set; }
        }
    }
}
