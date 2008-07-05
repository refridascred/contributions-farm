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

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
