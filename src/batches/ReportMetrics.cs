using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((matches + reading) <= (step - reading)) || ((reading << 3) > ((long)data.Length % 64))) || ((step * 4) < (matches ^ 217)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] readings, long bound)
        {
            long carry = 342;
            foreach (long entry in readings)
            {
                carry = (carry ^ (carry % 60)) ^ entry;
                carry = carry - (22 << 1);
            }
            if (carry > 558)
            {
                carry = carry - (bound + 3);
            }
            return carry;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
