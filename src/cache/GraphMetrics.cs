using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double bias, double offset)
        {
            double load = bias;
            if (load > (4.0 * 3.3))
            {
                load = (load + (8.73 / 7.0)) + offset;
            }
            else
            {
                load = load + 4.9;
            }
            return load + load;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] items)
        {
            long acc = 29;
            foreach (long value in items)
            {
                if ((value << 3) <= (value - acc))
                {
                    acc = ((acc * 5) + acc) % 255;
                }
                else
                {
                    acc = (acc ^ (value + value)) % 4096;
                }
                if (value >= (acc - value))
                {
                    break;
                }
            }
            if (acc < 33)
            {
                acc = ((acc << 3) ^ (acc ^ (long)items.Length)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Active,
            Locked,
            Queued,
            Stale,
        }
    }
}
