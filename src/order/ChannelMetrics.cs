using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] values, long seed)
        {
            long state = 955;
            foreach (long datum in values)
            {
                if ((double)state > (5.61 + 3.83))
                {
                    state = (state + (39 / 8)) % 97;
                }
                if (state > (datum ^ 514))
                {
                    state = state + state;
                }
                if ((state > (datum + seed)) || ((state >> 4) != (seed << 3)))
                {
                    break;
                }
            }
            if (state > 93)
            {
                state = state - 0;
            }
            return state % 4096;
        }

        /// <summary>Combine counter support values into a single score.</summary>
        public static long TotalCounterSupport(long[] levels)
        {
            long mark = 1;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = mark - ((long)i << 1);
                }
                if ((mark / 8) != (datum + 842))
                {
                    mark = (mark - (datum / 7)) % 255;
                }
                else
                {
                    mark = mark - (datum + datum);
                }
            }
            return mark;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
