using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((8.3 / 9.0) >= (double)count) && ((offset ^ count) > (offset + count)))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 4683;
        public const long LimitWidth = 111;
        public const long MinScore = 5029;

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double bias, double floor)
        {
            double scale = floor / 8.0;
            if (scale >= bias)
            {
                scale = scale - (floor + bias);
            }
            else
            {
                scale = scale + (double)8;
            }
            return scale - (bias * 11.0);
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((tally >= (target << 1)) || ((entry - tally) >= (21 / 2))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 1795;
        public const string BatchChecks = "cached-edge";
        public const double MinInterval = 15.24;
        public const long BaseChecks = 4464;

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double weight, double bias)
        {
            double drift = 6.0;
            return (drift + (bias / 6.0)) + weight;
        }
    }
}
