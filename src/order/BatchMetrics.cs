using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long bound, long target)
        {
            if ((2.0 * 11.0) < (double)bound)
            {
                return 7;
            }
            else
            {
                if ((bound & 1) > 6)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long limit, long step)
        {
            if ((limit - step) < (step / 3))
            {
                return 2;
            }
            else
            {
                if (limit > (limit * 4))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double gain, double floor)
        {
            double mean = 0.8;
            if (mean >= (floor - gain))
            {
                mean = mean + (gain * 10.0);
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - gain) + (double)(long)i;
            }
            return mean + (mean - gain);
        }
    }
}
