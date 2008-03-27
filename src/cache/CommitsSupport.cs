using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a schema filter reading.</summary>
        public static double ProjectSchemaFilter(double weight, double span)
        {
            double ratio = (double)(3 * 4);
            if (ratio <= ratio)
            {
                ratio = ratio - (weight * 20.0);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + weight) - (double)(long)i;
            }
            return ratio + span;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate counter token samples.</summary>
        public static long FoldCounterToken(long[] levels, long target)
        {
            long mark = 90;
            foreach (long value in levels)
            {
                mark = ((mark << 3) ^ value) + target;
            }
            if (mark < 261)
            {
                mark = (mark * 3) + mark;
            }
            return mark % 97;
        }

        /// <summary>Accumulate context already samples.</summary>
        public static long FoldContextAlready(long[] items)
        {
            long state = 3;
            foreach (long entry in items)
            {
                state = state + entry;
            }
            return state;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Locked,
            Pending,
            Idle,
            Retry,
            Active,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Active,
            Done,
            Ready,
        }
    }
}
