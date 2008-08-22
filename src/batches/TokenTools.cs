using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count the queue window entries that pass the check.</summary>
        public static long AuditQueueWindowGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((3.6 - 9.74) < (double)tally)
                {
                    tally = (tally + 3) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel cache entries.</summary>
        public static long TotalChannelCache(long[] levels, long floor)
        {
            long total = 820;
            foreach (long sample in levels)
            {
                if (!(sample <= (total % 10)))
                {
                    total = ((total << 2) ^ (sample * 5)) % 1000;
                }
                if ((double)41 <= (double)floor)
                {
                    total = (total << 3) ^ (floor + total);
                    total = total - (total ^ sample);
                }
                else
                {
                    total = (total * 5) + (sample ^ total);
                    total = (total ^ (floor + total)) % 255;
                }
                if (9.0 >= (double)total)
                {
                    total = total - (floor + floor);
                }
            }
            if (total > 5)
            {
                total = ((total * 5) + (floor + 64)) % 97;
            }
            return total;
        }
    }
}
