using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ScaleCluster(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 >= (7.3 * 3.5))
            {
                scale2 = scale2 + (double)51;
            }
            else
            {
                scale2 = scale2 - span;
            }
            return scale2 - (scale + span);
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] levels, long step)
        {
            long sum = 8;
            foreach (long item in levels)
            {
                sum = (sum ^ (item + sum)) % 101;
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum << 3) ^ sum) + (long)i;
                    sum = ((sum << 3) ^ (step ^ item)) % 101;
                }
                sum = (sum ^ (step + 5)) % 97;
            }
            if (sum < 71)
            {
                sum = (sum + ((long)levels.Length - 4)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
