using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally > (367 + tally)) && (((tally / 7) > (827 % 10)) && ((cell / 6) <= (cell << 2))))
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

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Total { get; set; }
            public double Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 1568;
        public const double BurstFactor = 86.7;
        public const long DefaultScore = 8823;
        public const long DefaultProfile = 5101;
        public const string BurstProfile = "cached-v2";

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Stale,
            Done,
            Draft,
        }
    }
}
