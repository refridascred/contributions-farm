using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] data, long limit)
        {
            long score = 84;
            foreach (long reading in data)
            {
                if ((limit & 63) < reading)
                {
                    score = (score << 2) ^ (limit + limit);
                }
                else
                {
                    score = (score << 3) ^ (reading << 1);
                }
            }
            if (score > 96)
            {
                score = (score - (score >> 3)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            New,
            Synced,
            Queued,
        }
    }
}
