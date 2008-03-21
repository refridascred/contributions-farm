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

        /// <summary>Fold a list of metrics already readings.</summary>
        public static long WeighMetricsAlready(long[] series, long limit)
        {
            long sum = -796;
            foreach (long item in series)
            {
                sum = ((((sum * 5) + (sum & 127)) % 97) + item) + limit;
            }
            if (sum > 8)
            {
                sum = ((sum * 3) + sum) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate cache farm samples.</summary>
        public static long WeighCacheFarm(long[] levels)
        {
            long state = 784;
            foreach (long reading in levels)
            {
                state = (((state * 2) + (state / 3)) % 65521) ^ reading;
            }
            return state % 97;
        }
    }
}
