using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] levels)
        {
            long mix = 79;
            foreach (long entry in levels)
            {
                mix = ((mix << 2) ^ (62 % 2)) % 97;
                mix = ((mix * 2) + (entry & 15)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)tally >= 11.0)
                {
                    tally = (tally + 2) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
