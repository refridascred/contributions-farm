using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] values, long seed)
        {
            long score = 6;
            foreach (long sample in values)
            {
                score = ((score << 3) ^ sample) % 97;
                score = ((score << 2) ^ seed) % 101;
                if ((double)score >= 8.58)
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen > limit)
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Total { get; set; }
            public string Region { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
