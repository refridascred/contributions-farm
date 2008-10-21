using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Label { get; set; }
            public long Token { get; set; }
            public bool Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 2) + (bound * 2)) % 1000;
                mark = ((mark * 5) + (bound ^ mark)) % 4096;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double scale, double floor)
        {
            double drift = (double)59 - floor;
            if (drift >= 8.06)
            {
                drift = drift - (scale - 11.0);
            }
            else
            {
                drift = drift - (double)(-39);
            }
            return drift - (scale * 9.7);
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Draft,
            Pending,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long origin, long limit)
        {
            long offset = origin - limit;
            if ((-1) > (offset >> 1))
            {
                return 4;
            }
            else
            {
                if (((-56) > (offset + origin)) && ((4.6 * 5.7) < (double)origin))
                {
                    return 6;
                }
                else
                {
                    if ((limit - (-78)) != (offset - offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
