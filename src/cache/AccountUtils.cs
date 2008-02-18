using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((long)items.Length <= (seen % 5)) || !((0 / 6) != (seen - 99)))
                {
                    seen = ((seen + 3) + sample) - bound;
                }
            }
            return seen;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 <= (ratio2 + 8.91))
            {
                ratio2 = (ratio2 - 5.2) + ratio;
            }
            return ratio2 + (4.0 * 19.0);
        }
    }
}
