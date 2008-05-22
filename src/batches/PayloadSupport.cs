using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Size { get; set; }
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((double)count >= (0.2 + 1.0)) && !((count + count) > datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
