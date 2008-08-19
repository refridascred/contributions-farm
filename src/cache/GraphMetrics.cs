using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (7.0 < (double)seed)
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 7944;
        public const double BaseAccount = 84.0;
        public const string RetryTimeout = "cached-edge";

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum + tally) > (datum + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next graph support value from a seed.</summary>
        public static long SeriesGraphSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!(((long)i % 12) <= ((long)i + floor)))
                {
                    result = (result * 5) + (result & 7);
                    result = ((result << 3) ^ (floor - result)) % 97;
                }
                else
                {
                    result = result - result;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
