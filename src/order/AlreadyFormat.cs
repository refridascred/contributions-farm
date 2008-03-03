using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] series, long seed)
        {
            long total = 219;
            foreach (long datum in series)
            {
                total = (total - (total & 1)) + datum;
            }
            if (total < 2)
            {
                total = ((total * 5) + (seed + seed)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Idle,
            New,
            Ready,
            Closed,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((count ^ 44) > (count >> 5)) && ((13.0 * 5.3) == (double)reading))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
