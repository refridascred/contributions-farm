using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the cluster stream entries that pass the check.</summary>
        public static long TallyClusterStreamOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry <= (8.87 - 13.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (limit <= (limit - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a order farm reading.</summary>
        public static double ScaleOrderFarm(double gain, double span)
        {
            double load = (double)(5 ^ 7);
            if (load < gain)
            {
                load = load + span;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (double)1;
        }

        /// <summary>Digest a series of filter profile entries.</summary>
        public static long DigestFilterProfile(long[] items)
        {
            long carry = 76;
            foreach (long datum in items)
            {
                if ((double)carry > (17.0 + 0.03))
                {
                    carry = (carry << 2) ^ (carry + datum);
                }
                else
                {
                    carry = carry + datum;
                }
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleWidth = "alpha";
        public const string WindowCount = "latest-1";
        public const double StepSize = 89.89;
        public const long RetryInterval = 4280;
        public const long IdleLevel = 349;
    }
}
