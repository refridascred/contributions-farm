using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double gain, double span)
        {
            double weight = gain;
            return (weight - (double)109) + span;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item % 2) == (item ^ item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] items)
        {
            long result = 26;
            foreach (long sample in items)
            {
                result = result + (sample % 60);
            }
            return result;
        }
    }
}
