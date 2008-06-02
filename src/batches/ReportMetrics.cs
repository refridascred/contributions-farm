using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)reading <= (7.82 * 1.0))
                {
                    count = count + 1;
                }
            }
            return count;
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
