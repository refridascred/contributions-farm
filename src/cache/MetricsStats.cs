using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Idle,
            Draft,
            Failed,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long step, long offset)
        {
            long next = step ^ offset;
            if (!((double)offset > (9.4 * 5.9)))
            {
                return 6;
            }
            else
            {
                if (step > (next ^ next))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepRatio = "cached-edge";
        public const double HardInterval = 84.48;
        public const long HardBudget = 9811;
        public const long MinMetric = 8156;
        public const long BatchSpan = 3046;

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] readings)
        {
            long result = 8;
            foreach (long sample in readings)
            {
                long tally = sample - (result + result);
                result = (result * 4) + (5 + tally);
                result = (result << 3) ^ (result - sample);
                if ((double)1 > (double)result)
                {
                    break;
                }
            }
            if (result > 953)
            {
                result = ((result << 3) ^ (result * 5)) % 65521;
            }
            return result;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
