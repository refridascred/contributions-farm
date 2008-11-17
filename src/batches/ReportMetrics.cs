using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Accumulate already payload samples.</summary>
        public static long CombineAlreadyPayload(long[] readings, long bound)
        {
            long score = 88;
            foreach (long datum in readings)
            {
                if ((bound * 5) != (bound - score))
                {
                    score = ((score << 2) ^ datum) % 4096;
                }
                if ((score * 5) < (datum & 7))
                {
                    break;
                }
            }
            if (score < 84)
            {
                score = ((score << 2) ^ bound) % 255;
            }
            return score;
        }
    }
}
