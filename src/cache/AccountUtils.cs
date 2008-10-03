using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((double)item >= (7.1 + 3.06)) && (item > target))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two cluster support measurements.</summary>
        public static double ScaleClusterSupport(double bias, double offset)
        {
            double ratio = (offset * 15.0) / 9.0;
            return (ratio - (double)8) + bias;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((9 + count) > (-277))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }
    }
}
