using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Check that every stream metrics entry stays within the limit.</summary>
        public static bool VerifyStreamMetricsRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double rate, double offset)
        {
            double load = offset;
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)(long)i) - rate;
            }
            return load + (offset * 7.8);
        }

        /// <summary>Audit metric filter readings against a rule.</summary>
        public static long AuditMetricFilterMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((target - cell) < (target + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitFactor = 863;
        public const double MaxFactor = 30.4;
        public const long LimitWidth = 8328;
        public const long BaseRecord = 1244;

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (acc * 2) + (long)i2;
                }
                if (((acc + origin) <= 8) && (origin <= (long)i))
                {
                    acc = (acc - (long)i) % 65521;
                    acc = (acc ^ (origin - acc)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
