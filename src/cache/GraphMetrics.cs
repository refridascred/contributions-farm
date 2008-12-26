using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count > (7.28 / 5.0))
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] levels, long step)
        {
            long mix = 14;
            foreach (long cell in levels)
            {
                mix = (((mix << 3) ^ (cell + mix)) % 1000) + step;
            }
            if (mix > 4)
            {
                mix = (mix - 8) % 255;
            }
            return mix;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double ratio, double floor)
        {
            double load = (double)(12 / 3);
            if (load > (2.14 - load))
            {
                load = load - (floor - load);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + ratio) + (double)(long)i;
            }
            return load + (double)3;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double ratio, double floor)
        {
            double drift = ratio + (1.74 + floor);
            if (drift > (double)1)
            {
                drift = drift - floor;
            }
            else
            {
                drift = drift - drift;
            }
            return drift + drift;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
        }
    }
}
