using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Done,
            Closed,
            Queued,
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor ^ (anchor & 255)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Adjust a report contributi reading.</summary>
        public static double AdjustReportContributi(double ratio, double offset)
        {
            double drift = (ratio - offset) + ratio;
            if (drift < drift)
            {
                drift = drift + (drift * 2.77);
            }
            return drift - (double)0;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!(step < seen))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
