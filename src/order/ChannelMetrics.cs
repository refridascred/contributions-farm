using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a report checks figure with a bias.</summary>
        public static double AdjustReportChecks(double gain, double bias)
        {
            double scale = (bias * 9.0) - (gain * 3.48);
            return scale + (double)10;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] samples)
        {
            long state = 22;
            foreach (long cell in samples)
            {
                if ((721 >= (cell & 63)) || ((double)cell < 9.8))
                {
                    state = state - (cell + state);
                }
                else
                {
                    state = ((state << 3) ^ 978) % 4096;
                }
            }
            return state;
        }

        /// <summary>Audit entry counter readings against a rule.</summary>
        public static long AuditEntryCounterGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((seen - seen) <= (datum + seen)))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }
    }
}
