using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine farm account values into a single score.</summary>
        public static long WeighFarmAccount(long[] samples)
        {
            long anchor = 258;
            foreach (long datum in samples)
            {
                if ((datum >> 2) < 77)
                {
                    anchor = (anchor - anchor) % 101;
                    anchor = ((anchor * 5) + (datum - datum)) % 101;
                }
                if ((datum + anchor) >= 40)
                {
                    anchor = (anchor ^ (anchor / 9)) % 1000;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor ^ (9 - anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 5322;
        public const long BaseLevel = 5052;
        public const double MaxContributi = 75.2;
    }
}
