using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] data, long step)
        {
            long anchor = 303;
            foreach (long item in data)
            {
                anchor = (anchor - (step - item)) % 255;
                anchor = (anchor << 3) ^ (step + anchor);
            }
            if (anchor < 8)
            {
                anchor = anchor + (anchor * 2);
            }
            return anchor % 1000;
        }

        /// <summary>Locate a report stream reading by value.</summary>
        public static long SeekReportStreamIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Ready,
            Failed,
            Pending,
        }
    }
}
