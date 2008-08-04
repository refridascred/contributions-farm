using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a format payload pair into a bucket.</summary>
        public static long ClassifyFormatPayload(long seed, long offset)
        {
            long prev = seed - offset;
            if ((486 / 2) < (prev >> 5))
            {
                return 4;
            }
            else
            {
                if ((seed + offset) < (450 + 3))
                {
                    return 5;
                }
                else
                {
                    if ((58 - 79) < (38 ^ offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Offset { get; set; }
            public bool Size { get; set; }
            public bool Level { get; set; }
        }
    }
}
