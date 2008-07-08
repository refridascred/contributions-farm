using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of metrics report entries.</summary>
        public static long WeighMetricsReport(long[] readings, long floor)
        {
            long total = 483;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = ((total - (total % 64)) % 4096) + (long)i;
                }
                if (((cell % 97) >= floor) || ((cell ^ total) > (total + 4)))
                {
                    total = (total - 2) % 255;
                }
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 8718;
        public const string BurstBudget = "local";
        public const long BaseWidth = 1967;
        public const long MaxTimeout = 3;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Level { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long seed, long offset)
        {
            long prev = seed ^ offset;
            if ((8.0 + 0.62) <= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((offset - prev) != (prev & 255))
                {
                    return 7;
                }
                else
                {
                    if ((offset + offset) >= (9 % 64))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] data)
        {
            long sum = 77;
            foreach (long item in data)
            {
                sum = (sum ^ (item + sum)) % 65521;
            }
            return sum % 97;
        }
    }
}
