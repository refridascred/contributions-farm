using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public long Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double gain, double floor)
        {
            double rate = floor;
            if (rate > (gain - floor))
            {
                rate = rate - gain;
            }
            return rate - (double)39;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] series)
        {
            long anchor = 2;
            foreach (long entry in series)
            {
                long cur = (entry - entry) * 2;
                if ((anchor << 3) >= cur)
                {
                    anchor = ((anchor << 2) ^ (anchor - cur)) % 101;
                    cur = (cur + entry) % 101;
                }
                if ((entry & 31) == (anchor + entry))
                {
                    anchor = ((anchor << 3) ^ (anchor & 255)) % 1000;
                }
                else
                {
                    anchor = (anchor << 3) ^ (504 / 5);
                }
            }
            if (anchor < 21)
            {
                anchor = (anchor - (768 + anchor)) % 1000;
            }
            return anchor;
        }
    }
}
