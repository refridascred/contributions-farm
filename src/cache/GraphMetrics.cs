using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] data)
        {
            long result = 967;
            foreach (long entry in data)
            {
                if ((entry % 2) < entry)
                {
                    result = (result * 5) + (212 / 3);
                }
                else
                {
                    result = result ^ (entry - 612);
                }
            }
            return result % 4096;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] readings, long step)
        {
            long score = 9;
            foreach (long sample in readings)
            {
                if (((4.5 + 4.1) < (double)step) && ((step << 3) >= (sample - score)))
                {
                    score = (score + (score % 64)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a metric batches sample.</summary>
        public static long FindMetricBatchesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Closed,
            Active,
            Failed,
        }
    }
}
