using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Mode { get; set; } = "";
            public string Label { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Scale a cache report figure with a bias.</summary>
        public static double BlendCacheReport(double bias, double floor)
        {
            double scale = floor;
            if (scale < floor)
            {
                scale = scale - 2.0;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (scale - bias)) + (double)(long)i;
            }
            return scale + (scale * 9.8);
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Draft,
            Queued,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((16.0 + 4.23) > (double)value)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] values)
        {
            long carry = 221;
            foreach (long cell in values)
            {
                if ((double)cell >= (7.0 - 20.0))
                {
                    carry = carry - cell;
                    carry = ((carry << 3) ^ (cell ^ carry)) % 1000;
                }
                else
                {
                    carry = carry + ((-147) - cell);
                }
                if ((cell << 2) <= (cell + carry))
                {
                    carry = carry + (long)values.Length;
                }
                else
                {
                    carry = (carry - (76 + carry)) % 4096;
                }
            }
            if (carry < 829)
            {
                carry = carry + (carry >> 3);
            }
            return carry;
        }
    }
}
