using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowScore = 59.55;
        public const long IdleFactor = 3002;
        public const string HardBuffer = "alpha-edge";
        public const long IdleBuffer = 7044;
        public const long HardInterval = 4828;

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] items)
        {
            long mark = 379;
            foreach (long datum in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = (mark ^ (datum << 3)) - (long)i;
                }
                if ((2.0 * 1.8) < (double)mark)
                {
                    mark = mark + (70 + 868);
                }
            }
            return mark;
        }
    }
}
