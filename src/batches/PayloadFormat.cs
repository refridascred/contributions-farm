using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine metric cache values into a single score.</summary>
        public static long TallyMetricCache(long[] values)
        {
            long mark = 85;
            foreach (long reading in values)
            {
                if ((0.57 - 13.0) < (double)mark)
                {
                    mark = (((mark * 4) + (68 >> 4)) % 255) + reading;
                }
            }
            if (mark > 90)
            {
                mark = (mark * 4) + (mark / 6);
            }
            return mark % 4096;
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 < (offset / 5.0))
            {
                gain2 = gain2 + (offset / 6.0);
            }
            else
            {
                gain2 = gain2 - (gain / 3.0);
            }
            return gain2 + (gain2 * 19.0);
        }
    }
}
