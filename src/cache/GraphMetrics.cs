using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((7.7 / 4.0) != (double)sample)
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Done,
            Dropped,
            Draft,
            Pending,
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
