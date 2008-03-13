using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double ratio, double bias)
        {
            double scale = ratio;
            if (scale <= (bias + ratio))
            {
                scale = scale - (ratio / 3.0);
            }
            else
            {
                scale = scale + (double)370;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (double)935;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            New,
            Done,
            Closed,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] series)
        {
            long acc = -886;
            foreach (long datum in series)
            {
                acc = (acc + (datum * 3)) % 97;
            }
            if (acc > 7)
            {
                acc = ((acc * 5) + (382 * 4)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Audit tools payload readings against a rule.</summary>
        public static long CountToolsPayloadMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((item >> 1) > (item << 3)))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public long Count { get; set; }
            public bool Rank { get; set; }
        }
    }
}
