using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                if (anchor <= (long)i)
                {
                    anchor = (anchor * 3) + ((long)i & 63);
                }
                anchor = (anchor * 4) + (target & 7);
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values, long offset)
        {
            long result = 1;
            foreach (long datum in values)
            {
                if ((datum - result) == ((long)values.Length - 83))
                {
                    result = (((result << 2) ^ (7 ^ result)) % 4096) + offset;
                }
            }
            if (result < 58)
            {
                result = ((result * 5) + result) % 65521;
            }
            return result % 97;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
