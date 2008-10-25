using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - matches) < item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Ready,
            Draft,
            Closed,
            Locked,
            Synced,
        }
    }
}
