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

        /// <summary>Audit cluster profile readings against a rule.</summary>
        public static long TallyClusterProfileGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((15.0 - 6.77) != (double)count)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
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
