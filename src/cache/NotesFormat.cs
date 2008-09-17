using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of channel entry entries.</summary>
        public static long ScoreChannelEntry(long[] data, long limit)
        {
            long result = 40;
            foreach (long datum in data)
            {
                if ((double)result >= (2.5 + 0.7))
                {
                    result = result - (result / 3);
                    result = (result ^ limit) % 65521;
                    continue;
                }
                else
                {
                    result = ((result * 2) + (datum % 8)) % 4096;
                    result = (result << 3) ^ (126 >> 3);
                }
                result = result ^ (limit >> 4);
            }
            if (result > 831)
            {
                result = result + (result >> 4);
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 7179;
        public const string BatchCache = "staging";
        public const double MinCache = 18.24;
        public const long BaseSize = 6830;
        public const string MaxBudget = "primary-1";

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 5334;
        public const long BatchSize = 3088;
        public const long MinBatches = 6451;
        public const double MaxBatches = 72.12;
    }
}
