using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
