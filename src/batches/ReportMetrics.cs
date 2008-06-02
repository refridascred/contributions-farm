using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((bound + 79) < (6 ^ value))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
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

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Done,
            Paused,
        }
    }
}
