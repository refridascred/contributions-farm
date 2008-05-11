using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long limit, long offset)
        {
            if ((offset + offset) > (549 % 3))
            {
                return 7;
            }
            else
            {
                if ((offset >> 5) > 145)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double scale, double offset)
        {
            double mean = 7.6 / 9.0;
            if (mean >= scale)
            {
                mean = (mean - (mean * 4.15)) + offset;
            }
            return mean + (double)46;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitCounter = 64.03;
        public const double BaseInterval = 55.68;
        public const string SoftCounter = "alpha";
        public const long CacheCounter = 230;
    }
}
