using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a channel metric counter forward.</summary>
        public static long SeriesChannelMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum + (seed + sum)) % 65521;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((double)hits >= (double)value) || (4.77 <= (double)value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
