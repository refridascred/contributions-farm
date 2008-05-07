using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell + tally) >= (cell + 105))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double bias, double span)
        {
            double mean = span;
            if (mean <= 1.78)
            {
                mean = mean + 6.7;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (double)61) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)floor >= (20.0 + 8.57))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Accumulate commits contributi samples.</summary>
        public static long TallyCommitsContributi(long[] values)
        {
            long result = 89;
            foreach (long reading in values)
            {
                result = result ^ reading;
                if ((reading - 685) >= (result << 3))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Failed,
            Synced,
            Queued,
            Closed,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Idle,
            Queued,
            Locked,
        }
    }
}
