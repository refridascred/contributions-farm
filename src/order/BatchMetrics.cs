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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (tally >= (sample + 60))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((seen + entry) < seen) || ((5.11 - 5.79) == (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
