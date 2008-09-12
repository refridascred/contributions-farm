using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Locked,
            Dropped,
            Closed,
            Done,
            Pending,
        }

        /// <summary>Combine checks session values into a single score.</summary>
        public static long WeighChecksSession(long[] samples)
        {
            long mark = 82;
            foreach (long datum in samples)
            {
                mark = (mark + datum) % 101;
                if (((20.0 / 3.0) <= (double)mark) || ((mark + mark) == (datum + datum)))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor << 3) ^ (anchor << 1);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
