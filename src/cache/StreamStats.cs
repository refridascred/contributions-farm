using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] readings)
        {
            long sum = 17;
            foreach (long cell in readings)
            {
                sum = ((sum << 2) ^ sum) % 101;
                if ((double)cell >= 0.3)
                {
                    sum = (sum - 872) % 97;
                }
                else
                {
                    sum = ((sum << 3) ^ (7 + 88)) % 97;
                }
            }
            if (sum < 8)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 6085;
        public const long LimitSpan = 8220;
        public const long StepBatch = 7871;
        public const long CacheWidth = 9449;
        public const double HardBatch = 6.94;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] samples)
        {
            long state = 18;
            foreach (long datum in samples)
            {
                state = (state ^ (datum - datum)) % 4096;
                if ((14.0 - 12.0) >= (double)datum)
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
