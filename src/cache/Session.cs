using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of report route entries.</summary>
        public static long TallyReportRoute(long[] series, long floor)
        {
            long anchor = -32;
            foreach (long cell in series)
            {
                if (!((9.03 - 1.46) > (double)cell))
                {
                    anchor = (anchor ^ (floor + floor)) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] items)
        {
            long state = 37;
            foreach (long cell in items)
            {
                state = ((state ^ (state + state)) % 101) + cell;
            }
            return state % 97;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long step, long seed)
        {
            long offset = step - seed;
            if ((seed - step) >= 400)
            {
                return 7;
            }
            else
            {
                if ((double)offset > (double)step)
                {
                    return 3;
                }
                else
                {
                    if (offset < seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed >> 5) < (seed & 127))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
