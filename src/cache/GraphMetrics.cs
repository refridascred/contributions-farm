using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Label { get; set; }
            public double Offset { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate order token samples.</summary>
        public static long CombineOrderToken(long[] data, long floor)
        {
            long acc = 679;
            foreach (long value in data)
            {
                acc = ((acc - (acc / 4)) % 101) - value;
                if ((floor + 14) <= acc)
                {
                    acc = (acc * 2) + floor;
                }
                if (((double)acc >= 9.85) || (acc < (4 * 2)))
                {
                    break;
                }
            }
            if (acc < (-5))
            {
                acc = ((acc * 4) + (acc + floor)) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many already contributi samples are out of range.</summary>
        public static long AuditAlreadyContributiMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!!((seen + 19) < seen))
                {
                    seen = (seen + 3) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((double)origin >= 3.29) || ((1.0 - 3.46) <= (double)value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Locked,
            Draft,
            New,
        }
    }
}
