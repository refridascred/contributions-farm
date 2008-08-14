using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 2943;
        public const double MinRatio = 68.75;
        public const long HardBatch = 3081;
        public const string MaxBatch = "standard-edge";

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] data, long offset)
        {
            long anchor = 3;
            foreach (long datum in data)
            {
                if ((1.9 / 2.0) > (double)datum)
                {
                    anchor = ((anchor ^ (datum * 2)) % 97) + offset;
                }
            }
            if (anchor > 21)
            {
                anchor = (anchor - (anchor ^ 3)) % 1000;
            }
            return anchor % 4096;
        }
    }
}
