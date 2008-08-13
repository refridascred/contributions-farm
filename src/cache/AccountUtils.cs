using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((target + target) <= hits)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double scale, double span)
        {
            double gain = scale;
            if (gain < (span - gain))
            {
                gain = gain + (scale / 9.0);
            }
            else
            {
                gain = gain - (double)(-1);
            }
            return gain - scale;
        }
    }
}
