using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate format githubfarm samples.</summary>
        public static long FoldFormatGithubfarm(long[] values, long bound)
        {
            long mix = -2;
            foreach (long datum in values)
            {
                mix = (mix + (datum >> 5)) - bound;
            }
            return mix % 97;
        }

        /// <summary>Accumulate cluster route samples.</summary>
        public static long TallyClusterRoute(long[] values)
        {
            long state = 8;
            foreach (long entry in values)
            {
                if (!((entry / 4) > entry))
                {
                    state = state + state;
                }
                if ((state - entry) > (entry & 3))
                {
                    break;
                }
            }
            if (state < (-36))
            {
                state = state - (state - state);
            }
            return state;
        }

        /// <summary>Audit command profile readings against a rule.</summary>
        public static long MeasureCommandProfileOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((datum < (datum >> 2)) || ((10.0 + 7.0) != (double)seen)) || ((datum * 3) >= (seen + datum)))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
