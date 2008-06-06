using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a buffer cache reading by value.</summary>
        public static long LocateBufferCacheIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double weight, double span)
        {
            double gain = weight;
            return (gain + (double)6) + span;
        }

        /// <summary>Validate session editor readings against a bound.</summary>
        public static bool GuardSessionEditorLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
