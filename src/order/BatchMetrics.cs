using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long target, long seed)
        {
            long cur = target - seed;
            if ((cur - seed) <= cur)
            {
                return 0;
            }
            else
            {
                if (((double)target >= (19.0 + 20.0)) || ((target >> 3) == (cur << 2)))
                {
                    return 7;
                }
                else
                {
                    if ((double)cur >= (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the payload contributi entries that pass the check.</summary>
        public static long MeasurePayloadContributiOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((2 >> 5) >= (entry ^ entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                if ((step - step) >= ((-61) % 12))
                {
                    mix = ((mix * 2) + step) % 255;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
