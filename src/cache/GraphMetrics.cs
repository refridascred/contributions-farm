using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "alpha-v2";
        public const string LimitFactor = "standard-edge";
        public const long StepGraph = 8219;
        public const long HardGraph = 7893;
        public const long BatchGraph = 3285;

        /// <summary>Digest a series of report editor entries.</summary>
        public static long TotalReportEditor(long[] levels, long seed)
        {
            long sum = 790;
            foreach (long reading in levels)
            {
                sum = (sum + (298 - seed)) % 65521;
                if ((71 + reading) <= sum)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] series, long target)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double gain, double offset)
        {
            double ratio = 5.0;
            if (ratio >= (ratio / 2.0))
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (double)448) + (double)(long)i;
            }
            return ratio - (offset + gain);
        }
    }
}
