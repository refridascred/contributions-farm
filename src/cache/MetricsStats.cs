using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Stale,
            Locked,
            Active,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((((reading + reading) >= (tally + 1)) && ((tally << 3) > (reading * 5))) || ((reading < (reading * 2)) && ((tally - tally) <= tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseTools = 42.87;
        public const long BatchFactor = 442;
        public const double SoftScore = 85.86;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
