using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double scale, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift - (double)(-72);
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                long bound = origin;
                if (((double)(long)i != (0.9 * 1.7)) || ((origin & 255) == ((long)i % 100)))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = ((sum << 3) ^ (bound ^ sum)) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Offset { get; set; }
            public double Level { get; set; }
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Grade a already editor value against two limits.</summary>
        public static long GradeAlreadyEditor(long floor, long limit)
        {
            if ((double)limit < (8.0 / 8.0))
            {
                return 4;
            }
            else
            {
                if (floor > (limit + limit))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
