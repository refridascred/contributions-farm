using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Adjust a cache batch reading.</summary>
        public static double ScaleCacheBatch(double gain, double offset)
        {
            double ratio = gain;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (gain + offset)) + (double)(long)i;
            }
            return ratio + (ratio - ratio);
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long seed, long bound)
        {
            long next = seed + bound;
            if ((next * 3) <= (next >> 5))
            {
                return 3;
            }
            else
            {
                if ((double)next >= (3.3 - 0.7))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Owner { get; set; }
            public string Count { get; set; } = "";
            public bool Total { get; set; }
            public double Flag { get; set; }
        }
    }
}
