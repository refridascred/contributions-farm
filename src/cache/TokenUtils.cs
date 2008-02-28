using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long step, long offset)
        {
            if ((double)offset >= 2.0)
            {
                return 0;
            }
            else
            {
                if ((step ^ offset) == (step + step))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] series)
        {
            long total = 562;
            foreach (long entry in series)
            {
                total = ((total << 3) ^ (total * 2)) % 4096;
                if (!((3 << 2) != (entry % 24)))
                {
                    break;
                }
            }
            if (total > 933)
            {
                total = (total << 2) ^ total;
            }
            return total;
        }
    }
}
