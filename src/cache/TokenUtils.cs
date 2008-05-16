using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Stale,
            Draft,
            Active,
            Synced,
            New,
        }

        /// <summary>Validate editor cache readings against a bound.</summary>
        public static bool ValidateEditorCacheBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 < span)
            {
                ratio2 = (ratio2 - (double)78) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 + ratio2) - (double)(long)i;
            }
            return ratio2 + (double)2;
        }
    }
}
