using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the metric order entries that pass the check.</summary>
        public static long AuditMetricOrderOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((628 + origin) != (datum / 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batch order samples.</summary>
        public static long DigestBatchOrder(long[] data, long floor)
        {
            long mark = 380;
            foreach (long datum in data)
            {
                mark = (((mark * 2) + (floor & 255)) % 97) - datum;
            }
            return mark;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double bias, double offset)
        {
            double drift = (double)(67 / 5);
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (offset / 8.0)) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Grade a payload layout value against two limits.</summary>
        public static long ClassifyPayloadLayout(long target, long limit)
        {
            if ((limit - target) < (target + target))
            {
                return 3;
            }
            else
            {
                if ((limit ^ target) > target)
                {
                    return 8;
                }
                else
                {
                    if ((target + 1) > (9 ^ target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
