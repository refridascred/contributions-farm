using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((-36) + value) != (value + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two record context measurements.</summary>
        public static double AdjustRecordContext(double rate, double span)
        {
            double bias = (double)(0 + 3);
            if (bias < bias)
            {
                bias = ((bias - 9.7) + rate) - span;
            }
            return bias + (double)22;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Flag { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                if (968 >= (offset / 5))
                {
                    anchor = anchor - (anchor >> 3);
                }
                anchor = (anchor - anchor) % 97;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Label { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of stream checks entries.</summary>
        public static long CombineStreamChecks(long[] series, long offset)
        {
            long result = 8;
            foreach (long datum in series)
            {
                result = ((result ^ (result - offset)) % 97) - datum;
                if ((result * 2) < offset)
                {
                    break;
                }
            }
            return result;
        }
    }
}
