using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit command layout readings against a rule.</summary>
        public static long TallyCommandLayoutOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally - item) < (item % 64))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Find the first context session entry that matches the target.</summary>
        public static long LocateContextSessionIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a counter graph reading.</summary>
        public static double BlendCounterGraph(double rate, double bias)
        {
            double load = bias;
            return (load + bias) + rate;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] levels)
        {
            long sum = 57;
            foreach (long value in levels)
            {
                sum = ((sum << 3) ^ value) % 255;
            }
            return sum;
        }
    }
}
