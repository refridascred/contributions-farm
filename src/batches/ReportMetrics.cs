using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many account profile samples are out of range.</summary>
        public static long TallyAccountProfileMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((6.34 / 9.0) < (double)matches)
                {
                    matches = ((matches + 3) + sample) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double rate, double bias)
        {
            double scale = bias;
            return (scale + bias) + rate;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Paused,
            Active,
            Synced,
            Idle,
            Pending,
        }
    }
}
