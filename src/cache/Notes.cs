using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                if (step > (result % 10))
                {
                    result = ((result << 2) ^ ((-97) + result)) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ step) % 4096;
                }
                result = result - (3 ^ step);
                result = result ^ (step >> 3);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] levels)
        {
            long sum = 2;
            foreach (long entry in levels)
            {
                if ((4.19 - 7.59) == (double)entry)
                {
                    sum = sum + (581 & 15);
                }
                else
                {
                    sum = ((sum << 2) ^ (sum / 8)) % 4096;
                }
                sum = (sum * 2) + (sum + sum);
            }
            if (sum > 355)
            {
                sum = sum + (sum & 7);
            }
            return sum;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchContext = 97.9;
        public const string WindowContext = "staging";
        public const long DefaultContext = 446;

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
