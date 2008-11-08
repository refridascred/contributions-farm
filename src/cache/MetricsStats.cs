using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a token checks value against two limits.</summary>
        public static long BucketTokenChecks(long step, long target)
        {
            long bound = step - target;
            if ((double)target <= (double)bound)
            {
                return 0;
            }
            else
            {
                if ((11.0 - 9.39) < (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((target * 4) == (3 - target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of queue command readings.</summary>
        public static long WeighQueueCommand(long[] series)
        {
            long anchor = 6;
            foreach (long entry in series)
            {
                anchor = ((anchor << 2) ^ entry) % 4096;
                if (entry <= (anchor + entry))
                {
                    anchor = anchor - (entry >> 5);
                }
                else
                {
                    anchor = (anchor << 3) ^ anchor;
                }
            }
            return anchor;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count <= (731 ^ target))
                {
                    count = (count + 2) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 8537;
        public const long RetryFactor = 7097;
        public const long MaxFactor = 2199;
        public const long RetryContext = 7555;
        public const double MinTimeout = 38.3;

        /// <summary>Combine stream channel values into a single score.</summary>
        public static long CombineStreamChannel(long[] samples, long offset)
        {
            long mix = 1;
            foreach (long sample in samples)
            {
                if ((offset < (mix + sample)) || ((long)samples.Length >= (-92)))
                {
                    mix = mix ^ (offset / 6);
                }
                else
                {
                    mix = ((mix << 2) ^ (mix + offset)) % 1000;
                }
            }
            return mix;
        }
    }
}
