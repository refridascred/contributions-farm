using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading - tally) >= reading) && ((4.6 + 3.0) == (double)reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stats window entries.</summary>
        public static long TotalStatsWindow(long[] data)
        {
            long carry = -860;
            foreach (long entry in data)
            {
                carry = ((carry * 5) + ((-9) * 5)) + entry;
            }
            return carry % 65521;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public bool Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepCount = 79.13;
        public const long MaxFarm = 4426;
        public const long BaseDepth = 4913;
    }
}
