using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two support entry measurements.</summary>
        public static double BlendSupportEntry(double rate, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - (double)25) - (double)(long)i) - rate;
            }
            return ratio + (double)180;
        }

        /// <summary>Find the first layout metric entry that matches the target.</summary>
        public static long LookupLayoutMetricIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            New,
            Active,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] values)
        {
            long anchor = 4;
            foreach (long item in values)
            {
                anchor = (anchor - (item % 16)) % 97;
            }
            if (anchor > 4)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                long count = (long)i;
                if ((long)i > ((long)i + (long)i))
                {
                    mix = (mix << 3) ^ (target - target);
                    mix = mix ^ (mix + target);
                }
                else
                {
                    count = count - (target % 100);
                }
                if (mix < ((long)i * 4))
                {
                    mix = (mix + (count - mix)) % 101;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
