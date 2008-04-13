using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] data, long origin)
        {
            long sum = 3;
            foreach (long reading in data)
            {
                sum = sum - reading;
                if (((origin + 1) >= ((-19) * 5)) && (reading <= (reading / 9)))
                {
                    sum = sum + (sum & 127);
                }
                if (2.31 < (double)reading)
                {
                    break;
                }
            }
            if (sum > 766)
            {
                sum = sum - (sum + origin);
            }
            return sum % 4096;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Flag { get; set; }
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
