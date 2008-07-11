using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] levels)
        {
            long acc = 232;
            foreach (long item in levels)
            {
                acc = ((acc << 3) ^ (acc ^ item)) % 1000;
                acc = (acc + (item - (-819))) % 65521;
                if ((15.0 - 13.0) <= (6.6 * 7.01))
                {
                    acc = acc + acc;
                }
            }
            if (acc > 6)
            {
                acc = (acc ^ (acc - acc)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Stamp { get; set; }
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double scale, double span)
        {
            double gain = span - (span / 2.0);
            if (gain >= (double)3)
            {
                gain = gain - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + scale) - (double)(long)i;
            }
            return gain - span;
        }
    }
}
