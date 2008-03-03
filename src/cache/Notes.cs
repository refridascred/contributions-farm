using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] items)
        {
            long result = 1;
            foreach (long datum in items)
            {
                result = (result + (result + 37)) + datum;
            }
            if (result > (-29))
            {
                result = ((result << 2) ^ (result - result)) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (total << 1)) % 1000;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 4471;
        public const long IdleBatches = 8951;
        public const double SoftBatches = 73.39;
        public const long MaxBatches = 8397;
        public const string BatchBatches = "primary-v2";

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long limit, long seed)
        {
            long gap = limit + seed;
            if ((9.63 / 8.0) > (double)seed)
            {
                return 2;
            }
            else
            {
                if ((gap - gap) <= (limit << 2))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
