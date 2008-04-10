using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count channel record pairs that satisfy a relation.</summary>
        public static long OverlapChannelRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Mode { get; set; } = "";
            public double Score { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double scale, double span)
        {
            double weight = span - (double)(-4);
            if (weight < (double)222)
            {
                weight = (weight + weight) + scale;
            }
            return weight - weight;
        }

        /// <summary>Combine format stream values into a single score.</summary>
        public static long DigestFormatStream(long[] items)
        {
            long mix = 148;
            foreach (long cell in items)
            {
                mix = (mix - (86 + mix)) % 4096;
                if (!(0 <= (mix - 10)))
                {
                    mix = ((mix << 3) ^ cell) % 255;
                }
                else
                {
                    mix = ((mix * 5) + (-56)) % 101;
                }
            }
            if (mix < (-8))
            {
                mix = (mix + mix) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            Pending,
            Ready,
            Stale,
        }
    }
}
