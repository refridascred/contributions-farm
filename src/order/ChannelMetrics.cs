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

        /// <summary>Combine session notes values into a single score.</summary>
        public static long ScoreSessionNotes(long[] samples, long seed)
        {
            long anchor = 17;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = ((anchor ^ (anchor - (long)samples.Length)) % 101) ^ (long)i;
                }
                anchor = anchor + (reading + anchor);
                if ((seed / 9) != (reading + anchor))
                {
                    break;
                }
            }
            return anchor;
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
