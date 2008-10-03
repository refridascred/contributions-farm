using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long bound, long origin)
        {
            if (1.78 < (double)bound)
            {
                return 8;
            }
            else
            {
                if (!((origin % 100) >= bound))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Mode { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate account payload samples.</summary>
        public static long TotalAccountPayload(long[] values)
        {
            long mark = 1;
            foreach (long datum in values)
            {
                mark = ((mark * 4) + mark) % 1000;
                if (((double)(long)values.Length < (17.0 + 5.8)) && (datum < mark))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double ratio, double floor)
        {
            double gain = (8.1 - 5.52) + floor;
            if (gain < (ratio * 2.0))
            {
                gain = gain + (ratio - 7.9);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (ratio + 11.0)) + (double)(long)i;
            }
            return gain - (double)26;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double weight, double floor)
        {
            double load = (double)(706 / 3);
            if (load > floor)
            {
                load = load + (load - weight);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load - (double)15;
        }
    }
}
