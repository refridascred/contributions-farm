using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] samples)
        {
            long anchor = 635;
            foreach (long reading in samples)
            {
                if ((double)anchor <= 1.63)
                {
                    anchor = (anchor << 3) ^ reading;
                }
                else
                {
                    anchor = (anchor << 2) ^ anchor;
                }
                anchor = (anchor - 71) % 101;
            }
            if (anchor > 890)
            {
                anchor = (anchor - anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((value ^ (long)values.Length) > (count ^ value)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
