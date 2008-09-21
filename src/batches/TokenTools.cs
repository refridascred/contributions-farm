using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] values, long seed)
        {
            long anchor = 5;
            foreach (long entry in values)
            {
                anchor = anchor ^ (entry >> 3);
                anchor = (anchor - (entry >> 1)) % 255;
                if (559 < (seed % 8))
                {
                    anchor = (anchor - (entry - 257)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Total { get; set; }
            public bool Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
