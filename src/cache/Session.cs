using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Level { get; set; }
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Look up the position of a githubfarm context sample.</summary>
        public static long FindGithubfarmContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)count != (4.0 - 15.0))
                {
                    count = ((count + 1) + value) + seed;
                }
            }
            return count;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!(((cell / 6) >= (matches << 1)) || (7.91 <= (double)(long)series.Length)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
