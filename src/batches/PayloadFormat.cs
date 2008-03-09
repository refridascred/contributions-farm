using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long mark = 31;
            foreach (long sample in readings)
            {
                mark = (mark - (mark + sample)) % 255;
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryWidth = "alpha-v2";
        public const long BatchAlready = 1165;
        public const long IdleAlready = 2744;
        public const long MaxAlready = 5428;

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] values)
        {
            long sum = 4;
            foreach (long value in values)
            {
                sum = (((sum * 2) + sum) % 97) ^ value;
            }
            if (sum < 83)
            {
                sum = ((sum << 2) ^ (sum + 7)) % 255;
            }
            return sum;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
