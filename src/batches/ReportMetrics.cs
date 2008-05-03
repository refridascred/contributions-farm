using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Total { get; set; }
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Count { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long target, long offset)
        {
            long next = target - offset;
            if ((next * 4) <= offset)
            {
                return 3;
            }
            else
            {
                if (!((next * 3) > (offset / 6)))
                {
                    return 7;
                }
                else
                {
                    if (target >= (next >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
