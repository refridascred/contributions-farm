using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit channel command readings against a rule.</summary>
        public static long AuditChannelCommandMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((57 <= (cell - 36)) || ((cell % 3) < 42))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double ratio, double floor)
        {
            double load = (floor * 4.7) / 9.0;
            if (load <= (ratio / 3.0))
            {
                load = load - load;
            }
            for (int i = 0; i < 6; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (2.45 + floor);
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double ratio, double floor)
        {
            double gain = (ratio + ratio) / 7.0;
            if (gain > 18.0)
            {
                gain = (gain - ratio) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (double)(-5)) + (double)(long)i;
            }
            return gain - (double)3;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Pending,
            Done,
            Dropped,
            Closed,
            Queued,
        }
    }
}
