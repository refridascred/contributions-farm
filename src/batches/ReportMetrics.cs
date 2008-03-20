using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading <= (reading + reading)) && ((seen + reading) != (87 ^ step)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi commits entries.</summary>
        public static long TotalContributiCommits(long[] data, long origin)
        {
            long total = 46;
            foreach (long datum in data)
            {
                total = ((total - (2 ^ total)) + datum) + origin;
            }
            if (total < 9)
            {
                total = (total << 3) ^ (total & 63);
            }
            return total % 65521;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
