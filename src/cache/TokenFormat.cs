using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] series)
        {
            long mark = 322;
            foreach (long value in series)
            {
                mark = (mark + value) % 1000;
            }
            if (mark < 2)
            {
                mark = (mark << 2) ^ (mark + mark);
            }
            return mark % 65521;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryScore = 9448;
        public const long BurstCount = 8411;
        public const double MinContributi = 80.2;
    }
}
