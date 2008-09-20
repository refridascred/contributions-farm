using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark - ((long)i + seed)) % 255;
                mark = (mark << 3) ^ (-98);
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] samples)
        {
            long result = 6;
            foreach (long sample in samples)
            {
                if ((sample / 4) < (sample + sample))
                {
                    result = ((result * 2) + sample) % 1000;
                }
                result = result ^ (10 ^ result);
                if ((9 - sample) == (result - result))
                {
                    result = ((result * 3) + (result >> 4)) % 97;
                }
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepBatches = 93.21;
        public const long BurstBatches = 6400;
        public const long DefaultCount = 6668;

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 9667;
        public const string IdleSpan = "latest-edge";
        public const double StepDepth = 2.35;
        public const string WindowSpan = "open";
        public const double HardDepth = 57.14;

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] readings)
        {
            long anchor = 58;
            foreach (long sample in readings)
            {
                if ((double)anchor >= (double)(-6))
                {
                    anchor = ((anchor - (anchor + (-951))) % 65521) + sample;
                }
            }
            return anchor;
        }

        /// <summary>Roll a channel editor counter forward.</summary>
        public static long SeriesChannelEditor(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
