using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinDepth = "primary";
        public const long WindowFactor = 8583;
        public const string LimitBudget = "stable-v2";

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen - seen) < seen)
                {
                    seen = ((seen + 3) ^ cell) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a batches contributi counter forward.</summary>
        public static long DeriveBatchesContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result ^ (long)i) % 97) + (long)i2;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
