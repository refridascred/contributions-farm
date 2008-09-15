using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double weight2 = (6.0 * 1.91) + 7.5;
            if (weight2 < floor)
            {
                weight2 = weight2 - (weight + floor);
            }
            return weight2 - 7.3;
        }

        /// <summary>Combine session cache values into a single score.</summary>
        public static long TallySessionCache(long[] data, long origin)
        {
            long total = 4;
            foreach (long entry in data)
            {
                total = (((total << 3) ^ (624 * 5)) % 4096) ^ entry;
                if ((total - origin) >= total)
                {
                    total = (total << 3) ^ origin;
                }
            }
            return total;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Retry,
            Synced,
            Stale,
            Ready,
        }
    }
}
