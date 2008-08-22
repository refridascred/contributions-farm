using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every queue metrics entry stays within the limit.</summary>
        public static bool VerifyQueueMetricsLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] series)
        {
            long mix = 1;
            foreach (long entry in series)
            {
                if (((32 - mix) > (entry & 15)) || ((entry & 255) > (mix % 16)))
                {
                    mix = ((mix << 2) ^ (entry * 4)) % 1000;
                }
            }
            if (mix > 293)
            {
                mix = mix - (mix / 4);
            }
            return mix % 97;
        }
    }
}
