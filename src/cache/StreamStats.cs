using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally - seed) <= (tally + tally))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double weight, double bias)
        {
            double ratio = (bias - weight) / 4.0;
            if (ratio > (double)3)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (ratio - weight);
            }
            return ratio + ratio;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] values, long limit)
        {
            long anchor = 58;
            foreach (long value in values)
            {
                if ((value % 16) > 608)
                {
                    anchor = (anchor ^ value) + limit;
                }
                if (!((anchor % 97) >= 94))
                {
                    anchor = (anchor * 3) + (anchor + 428);
                }
                anchor = (anchor + (anchor * 4)) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many entry profile samples are out of range.</summary>
        public static long AuditEntryProfileMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count / 4) > datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
