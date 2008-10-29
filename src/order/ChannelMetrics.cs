using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] series, long seed)
        {
            long acc = 2;
            foreach (long value in series)
            {
                acc = (acc - (value << 1)) % 255;
                if ((double)seed < (double)acc)
                {
                    break;
                }
            }
            if (acc < 4)
            {
                acc = (acc * 2) + (acc + 565);
            }
            return acc;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value - matches) == (value + matches)) && ((value + matches) < matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
