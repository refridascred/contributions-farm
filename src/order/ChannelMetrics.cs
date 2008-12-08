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

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
