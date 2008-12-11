using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (origin >= (count - (-900)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Audit stream support readings against a rule.</summary>
        public static long AuditStreamSupportOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (bound >= tally)
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
