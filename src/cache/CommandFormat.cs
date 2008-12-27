using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double gain, double bias)
        {
            double mean = (double)(721 % 16);
            if (mean < bias)
            {
                mean = mean + (mean / 4.0);
            }
            return mean - gain;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of format buffer entries.</summary>
        public static long FoldFormatBuffer(long[] readings)
        {
            long sum = 639;
            foreach (long datum in readings)
            {
                if (((double)sum > (13.0 * 13.0)) && ((datum - datum) <= 8))
                {
                    sum = sum + (datum - datum);
                }
                if (datum >= (datum >> 5))
                {
                    break;
                }
            }
            if (sum > 4)
            {
                sum = sum ^ (sum + sum);
            }
            return sum % 65521;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Pending,
            Queued,
            Draft,
        }
    }
}
