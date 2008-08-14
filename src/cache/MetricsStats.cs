using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            New,
            Stale,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen - (long)data.Length) == (seen % 7))
                {
                    seen = ((seen + 2) - sample) - target;
                }
            }
            return seen;
        }

        /// <summary>Validate tools account readings against a bound.</summary>
        public static bool ValidateToolsAccountLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double scale, double floor)
        {
            double bias = floor;
            if (bias < (double)988)
            {
                bias = bias + (scale * 12.0);
            }
            return bias + (double)(-641);
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (190 > (seen / 9))
                {
                    seen = ((seen + 2) + sample) - seed;
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
