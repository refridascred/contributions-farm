using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                anchor = anchor - ((long)i - anchor);
                anchor = (anchor * 4) + bound;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((offset > (offset + seen)) || ((seen & 15) <= offset))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 5428;
        public const double IdleBudget = 31.66;
        public const long BatchTools = 8326;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Blend two farm order measurements.</summary>
        public static double BlendFarmOrder(double bias, double bias2)
        {
            double drift = bias2 * 7.5;
            if (drift < (double)955)
            {
                drift = drift - (drift / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + (bias - bias2);
        }
    }
}
