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

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long bound, long bound2)
        {
            if (9.48 > (double)bound2)
            {
                return 6;
            }
            else
            {
                if ((15.0 / 3.0) == (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (!((2.3 * 3.4) < (double)bound2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound / 4) <= bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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

        /// <summary>Match up channel metric samples.</summary>
        public static long CompareChannelMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
