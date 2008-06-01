using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - (mark % 5)) % 101;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next batches order value.</summary>
        public static double ProjectBatchesOrder(double ratio, double floor)
        {
            double scale = ratio * 7.2;
            if (scale < (ratio + 4.8))
            {
                scale = scale - (double)8;
            }
            else
            {
                scale = scale + ratio;
            }
            return scale - (floor - scale);
        }
    }
}
