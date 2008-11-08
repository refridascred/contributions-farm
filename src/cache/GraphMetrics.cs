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

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultDepth = 2197;
        public const string BaseSchema = "latest";
        public const long MinSchema = 4351;
        public const long DefaultSchema = 7822;

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
