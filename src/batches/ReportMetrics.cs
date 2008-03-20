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

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long step, long floor)
        {
            long span = step ^ floor;
            if (span <= step)
            {
                return 7;
            }
            else
            {
                if ((3.8 - 8.94) <= (double)span)
                {
                    return 8;
                }
                else
                {
                    if (!((double)floor < (2.0 / 4.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
