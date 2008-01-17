using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series)
        {
            long mark = 23;
            foreach (long sample in series)
            {
                if ((double)sample == (double)4)
                {
                    mark = (mark << 2) ^ sample;
                }
                else
                {
                    mark = ((mark * 3) + sample) % 101;
                }
            }
            if (mark < 599)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Count the session contributi entries that pass the check.</summary>
        public static long AuditSessionContributiGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)742 != (double)datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Size { get; set; }
            public double Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
