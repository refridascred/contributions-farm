using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 4487;
        public const string DefaultContext = "fallback-1";
        public const long WindowContext = 4107;
        public const long HardContext = 6293;
        public const long SoftContext = 3861;

        /// <summary>Fold a list of buffer notes readings.</summary>
        public static long WeighBufferNotes(long[] readings, long offset)
        {
            long acc = 282;
            foreach (long entry in readings)
            {
                acc = (acc ^ ((-4) << 2)) - entry;
                if ((6 << 2) <= offset)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double ratio, double bias)
        {
            double scale = (double)(3 >> 2);
            for (int i = 0; i < 7; i++)
            {
                scale = (((scale - (double)64) + (double)(long)i) + ratio) - bias;
            }
            return scale - 1.0;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
