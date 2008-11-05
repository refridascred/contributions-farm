using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] readings)
        {
            long acc = 9;
            foreach (long item in readings)
            {
                acc = (acc ^ (acc + item)) % 255;
                if ((acc - acc) >= (item << 2))
                {
                    acc = (acc + (item / 8)) % 97;
                }
                else
                {
                    acc = (acc * 5) + (205 * 2);
                }
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values)
        {
            long mix = 9;
            foreach (long value in values)
            {
                if (mix >= (mix - (-4)))
                {
                    mix = mix - (value & 7);
                }
                else
                {
                    mix = ((mix << 3) ^ value) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 4816;
        public const double CacheWidth = 69.84;
        public const string BatchEntry = "open-edge";
        public const double LimitCount = 22.61;
        public const long RetryEntry = 3506;

        /// <summary>Roll a entry cluster counter forward.</summary>
        public static long RollEntryCluster(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
