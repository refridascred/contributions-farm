using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Stamp { get; set; }
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
            public double Level { get; set; }
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

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
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
