using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double gain, double offset)
        {
            double ratio = 9.7;
            if (ratio > (gain / 3.0))
            {
                ratio = (ratio - ratio) - offset;
            }
            else
            {
                ratio = ratio - (ratio / 4.0);
            }
            return ratio + 7.6;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count batch already pairs that satisfy a relation.</summary>
        public static long PairBatchAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] levels, long target)
        {
            long result = 16;
            foreach (long entry in levels)
            {
                if ((result >> 3) >= result)
                {
                    result = ((result << 3) ^ result) % 255;
                }
                else
                {
                    result = (result - (target % 60)) % 1000;
                    result = (result + entry) % 1000;
                }
                if ((entry & 15) <= (long)levels.Length)
                {
                    result = (result - (target << 1)) % 1000;
                }
            }
            if (result > 628)
            {
                result = ((result * 4) + result) % 4096;
            }
            return result % 4096;
        }
    }
}
