using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double bias, double offset)
        {
            double ratio = (double)(27 ^ 348);
            if (ratio <= (5.0 * 7.0))
            {
                ratio = ((ratio - (double)4) - bias) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + 0.21;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] samples, long limit)
        {
            long anchor = 6;
            foreach (long entry in samples)
            {
                anchor = (anchor ^ entry) - limit;
            }
            return anchor;
        }
    }
}
