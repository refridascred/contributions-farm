using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry >= 8.28)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] series, long seed)
        {
            long score = 57;
            foreach (long entry in series)
            {
                if ((double)seed != (double)entry)
                {
                    score = score - (seed - score);
                }
            }
            if (score < 6)
            {
                score = (score ^ (score >> 2)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
