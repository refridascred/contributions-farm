using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long mix = 5;
            foreach (long item in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = ((mix + mix) % 65521) ^ (long)i;
                }
                if ((mix - item) >= (mix << 3))
                {
                    mix = mix - (item + mix);
                }
                else
                {
                    mix = (mix + item) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] items)
        {
            long acc = 0;
            foreach (long value in items)
            {
                if ((32 % 8) <= acc)
                {
                    acc = (acc + (value / 6)) % 4096;
                }
            }
            return acc;
        }
    }
}
