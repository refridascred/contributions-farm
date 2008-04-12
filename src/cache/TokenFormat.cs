using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultLevel = "standard-edge";
        public const long DefaultWindow = 140;
        public const long DefaultSpan = 1456;
        public const long LimitWindow = 8116;

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] values, long limit)
        {
            long sum = 283;
            foreach (long datum in values)
            {
                if ((datum & 127) > limit)
                {
                    sum = sum + datum;
                }
                else
                {
                    sum = (sum * 2) + (sum * 4);
                }
            }
            return sum % 65521;
        }
    }
}
