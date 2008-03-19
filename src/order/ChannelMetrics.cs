using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] levels)
        {
            long mark = 88;
            foreach (long reading in levels)
            {
                mark = (mark - (mark + 78)) ^ reading;
            }
            return mark % 97;
        }

        /// <summary>Roll a commits already counter forward.</summary>
        public static long IterateCommitsAlready(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((long)i < (0 + 7))
                {
                    result = result ^ (limit + (long)i);
                    break;
                }
                else
                {
                    result = (result - result) % 65521;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultGraph = 51.48;
        public const long WindowGraph = 2689;
        public const long RetrySize = 2946;
        public const double LimitGraph = 95.06;
    }
}
