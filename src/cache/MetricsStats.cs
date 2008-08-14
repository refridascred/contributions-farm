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

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double gain, double offset)
        {
            double scale = 6.3;
            if (scale > (gain + offset))
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (gain + offset)) + (double)(long)i;
            }
            return scale + scale;
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
