using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] series, long limit)
        {
            long result = 1;
            foreach (long entry in series)
            {
                result = (result + (limit + entry)) % 4096;
                if (!((double)entry >= 14.0))
                {
                    result = result ^ limit;
                }
                if ((limit % 2) <= 24)
                {
                    break;
                }
            }
            if (result > 847)
            {
                result = ((result * 4) + (result + result)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Ready,
            Done,
            Active,
            Failed,
            Paused,
        }
    }
}
