using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count * 3) < (98 >> 2))
                {
                    count = (count + 1) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] series, long bound)
        {
            long result = 821;
            foreach (long entry in series)
            {
                if ((result & 3) <= entry)
                {
                    result = (result ^ (666 + 729)) - bound;
                }
            }
            return result;
        }
    }
}
