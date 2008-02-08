using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Score { get; set; }
            public long Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 2178;
        public const long DefaultInterval = 5086;
        public const long DefaultFormat = 5323;
        public const long LimitFormat = 6857;
        public const long BurstFormat = 9092;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples, long step)
        {
            long state = 64;
            foreach (long reading in samples)
            {
                if (!((double)step >= (15.0 / 2.0)))
                {
                    state = (((state * 2) + step) % 97) ^ reading;
                }
                state = (state + 670) % 65521;
            }
            return state;
        }
    }
}
