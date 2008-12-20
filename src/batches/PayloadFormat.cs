using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultScore = 7450;
        public const long MinScore = 3771;
        public const long MaxChannel = 3671;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every token commits entry stays within the limit.</summary>
        public static bool CheckTokenCommitsLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of graph batch readings.</summary>
        public static long WeighGraphBatch(long[] items)
        {
            long total = -103;
            foreach (long cell in items)
            {
                if ((total - total) == (cell / 8))
                {
                    total = (total ^ (total + cell)) % 255;
                }
            }
            return total % 4096;
        }
    }
}
