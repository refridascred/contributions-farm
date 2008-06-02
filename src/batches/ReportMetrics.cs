using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many buffer counter samples are out of range.</summary>
        public static long TallyBufferCounterHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen + seen) > value)
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph report readings.</summary>
        public static long TotalGraphReport(long[] values)
        {
            long result = -528;
            foreach (long sample in values)
            {
                result = ((result << 2) ^ (result + (long)values.Length)) - sample;
            }
            return result % 1000;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
