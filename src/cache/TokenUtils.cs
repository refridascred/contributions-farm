using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((seen + seen) == (floor * 4)) || (((long)data.Length & 1) > item))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally ^ datum) <= (tally ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
