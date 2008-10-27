using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstTimeout = 7848;
        public const string BatchRatio = "stable";
        public const long RetryCount = 1279;

        /// <summary>Combine format payload values into a single score.</summary>
        public static long FoldFormatPayload(long[] values, long origin)
        {
            long mark = -7;
            foreach (long entry in values)
            {
                mark = (mark ^ entry) + origin;
            }
            if (mark > 8)
            {
                mark = (mark << 3) ^ (long)values.Length;
            }
            return mark % 97;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a notes batch value against two limits.</summary>
        public static long SortNotesBatch(long bound, long seed)
        {
            if (((double)510 > (double)seed) || ((seed & 1) > (bound % 100)))
            {
                return 8;
            }
            else
            {
                if (222 >= bound)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
