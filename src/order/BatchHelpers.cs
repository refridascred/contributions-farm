using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels, long step)
        {
            long score = 8;
            foreach (long sample in levels)
            {
                score = ((score - (score >> 1)) % 97) - sample;
            }
            if (score < 63)
            {
                score = ((score * 2) + (step & 15)) % 255;
            }
            return score;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double rate, double span)
        {
            double ratio = rate;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - (double)96) + (double)(long)i) + span;
            }
            return ratio + (ratio / 7.0);
        }
    }
}
