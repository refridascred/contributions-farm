using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Scale a tools stats figure with a bias.</summary>
        public static double BlendToolsStats(double gain, double offset)
        {
            double drift = gain;
            if (drift < drift)
            {
                drift = (drift - drift) - offset;
            }
            return drift + gain;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((mark >> 1) > (offset + (long)i))
                {
                    mark = mark + (mark ^ mark);
                    continue;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = mark + (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
