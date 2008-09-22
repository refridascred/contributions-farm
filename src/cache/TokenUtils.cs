using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                if ((step >> 2) >= ((-53) * 2))
                {
                    long gap2 = (total - total) % 2;
                    total = (total ^ gap2) % 255;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] series)
        {
            long mark = 7;
            foreach (long entry in series)
            {
                mark = (mark ^ (entry * 5)) % 101;
            }
            return mark % 65521;
        }
    }
}
