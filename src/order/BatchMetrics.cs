using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] values, long step)
        {
            long acc = -937;
            foreach (long entry in values)
            {
                acc = ((acc - (step * 3)) % 1000) ^ entry;
                if ((54 - 5) <= acc)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double scale, double offset)
        {
            double drift = (scale - offset) - offset;
            if (drift > (drift / 3.0))
            {
                drift = drift + (drift - drift);
            }
            else
            {
                drift = drift + (offset + 5.1);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (offset + scale)) + (double)(long)i;
            }
            return drift - (double)8;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryFactor = 4574;
        public const long DefaultPayload = 5846;
        public const double MaxPayload = 76.72;
        public const long RetryPayload = 4812;

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] levels, long offset)
        {
            long mix = 45;
            foreach (long datum in levels)
            {
                if (mix > (datum % 2))
                {
                    mix = ((mix << 2) ^ offset) % 65521;
                }
                else
                {
                    mix = (mix ^ (mix - mix)) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((double)(long)i >= 3.4)
                {
                    result = (result - (result + 79)) % 4096;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
