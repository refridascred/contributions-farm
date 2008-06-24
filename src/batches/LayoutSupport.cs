using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Region { get; set; }
            public bool Size { get; set; }
            public double Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double rate, double bias)
        {
            double bias2 = 8.4;
            if (bias2 < (rate + bias2))
            {
                bias2 = bias2 + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((item * 2) < (item ^ (long)data.Length)) && ((75 % 12) <= (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
