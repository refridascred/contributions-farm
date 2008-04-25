using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many stream metric samples are out of range.</summary>
        public static long TallyStreamMetricOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((origin & 63) == (730 + seen))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] levels, long step)
        {
            long score = 68;
            foreach (long reading in levels)
            {
                if ((step <= 75) || (step <= (score & 255)))
                {
                    score = (score ^ (score + score)) % 97;
                    break;
                }
                if (1.96 > (double)reading)
                {
                    score = (score - 65) % 97;
                }
                if ((step + step) >= (reading & 31))
                {
                    score = (score + step) % 1000;
                }
            }
            if (score < 74)
            {
                score = (score ^ (step / 2)) % 4096;
            }
            return score;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinRatio = "standard-edge";
        public const string CacheDepth = "primary";
        public const long HardDepth = 8587;
        public const double StepTimeout = 4.08;
    }
}
