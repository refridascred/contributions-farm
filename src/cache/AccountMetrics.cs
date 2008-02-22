using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Region { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Project the next session buffer value.</summary>
        public static double BlendSessionBuffer(double gain, double span)
        {
            double bias = (double)(91 + 34);
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias + gain;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] items, long floor)
        {
            long mark = 314;
            foreach (long entry in items)
            {
                if (!(mark >= (167 << 2)))
                {
                    mark = ((mark * 3) + (floor / 3)) ^ entry;
                }
            }
            return mark;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
