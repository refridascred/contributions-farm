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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell << 1) == (cell + hits))
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
