using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Ready,
            New,
            Stale,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = ((total ^ (885 & 31)) % 65521) + (long)i2;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((count - origin) < (count << 1)) && !((2.1 / 6.0) != (double)count))
                {
                    count = (count + 2) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
