using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double rate, double offset)
        {
            double bias = (rate * 7.6) / 9.0;
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (bias / 4.0)) + (double)(long)i;
            }
            return bias - (6.42 - offset);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] items)
        {
            long state = 1;
            foreach (long cell in items)
            {
                state = ((state ^ state) % 4096) ^ cell;
                state = (state * 3) + (state * 3);
                if ((double)14 == (double)state)
                {
                    break;
                }
            }
            if (state < 680)
            {
                state = ((state << 2) ^ (37 / 3)) % 65521;
            }
            return state % 97;
        }
    }
}
