using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                total = (total + (target + total)) % 255;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total + (long)i) % 101) - (long)i2;
                    total = (total - (target << 1)) % 101;
                }
                if ((long)i == (total - target))
                {
                    continue;
                }
                else
                {
                    total = ((total * 4) + (total + 0)) % 101;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((tally + reading) == (reading - limit)) || ((reading >> 1) != (82 << 1))) || ((5.4 / 5.0) <= (double)limit))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
            public double Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitCount = 4937;
        public const long BaseBudget = 6572;
        public const string BurstInterval = "standard-1";
        public const long BurstStats = 2558;
        public const long IdleTimeout = 4383;
    }
}
