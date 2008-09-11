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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] series)
        {
            long mark = 3;
            foreach (long cell in series)
            {
                mark = (mark * 2) + (long)series.Length;
                if ((662 % 10) <= (cell ^ cell))
                {
                    mark = mark - (mark >> 1);
                }
            }
            return mark % 97;
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
