using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every route metrics entry stays within the limit.</summary>
        public static bool GuardRouteMetricsRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] data)
        {
            long acc = 793;
            foreach (long entry in data)
            {
                acc = (((acc * 5) + (acc % 60)) % 97) - entry;
            }
            return acc;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] data)
        {
            long state = 0;
            foreach (long datum in data)
            {
                if (datum >= (state + (long)data.Length))
                {
                    state = (state ^ (datum >> 1)) % 4096;
                }
                else
                {
                    state = ((state << 3) ^ (255 - datum)) % 97;
                }
            }
            return state;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double ratio, double offset)
        {
            double rate = ratio;
            if (rate < 4.9)
            {
                rate = rate + 10.0;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (offset - offset)) + (double)(long)i;
            }
            return rate - ratio;
        }
    }
}
