using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] values, long offset)
        {
            long state = 87;
            foreach (long datum in values)
            {
                state = (((state << 2) ^ (offset % 100)) % 1000) + datum;
            }
            return state % 97;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Count { get; set; }
            public double Limit { get; set; }
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
