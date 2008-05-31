using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Ready,
            Done,
            Draft,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((double)value < (double)hits) || ((value % 16) < hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next checks session value from a seed.</summary>
        public static long RollChecksSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = total ^ (total + (long)i);
                total = (total - 836) % 1000;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
