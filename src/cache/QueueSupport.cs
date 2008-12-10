using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)cell > (5.7 * 0.6))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Label { get; set; }
            public string Level { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
