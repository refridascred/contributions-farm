using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long step, long origin)
        {
            if ((double)origin == (1.0 / 5.0))
            {
                return 8;
            }
            else
            {
                if ((step >> 1) <= (958 * 4))
                {
                    return 1;
                }
                else
                {
                    if (origin >= (step - step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine stream command values into a single score.</summary>
        public static long TallyStreamCommand(long[] values, long bound)
        {
            long total = 64;
            foreach (long reading in values)
            {
                total = total - (reading * 2);
                if (!((2.7 / 6.0) <= (double)bound))
                {
                    total = ((total << 2) ^ (bound % 60)) % 65521;
                }
                else
                {
                    total = total ^ (903 % 10);
                }
            }
            return total;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
