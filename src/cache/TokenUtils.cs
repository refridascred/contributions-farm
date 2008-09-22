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

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long offset, long seed)
        {
            if ((offset & 3) >= (5 << 1))
            {
                return 2;
            }
            else
            {
                if (21 >= (offset - offset))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
