using System;

namespace Common.Utilities
{
    /// <summary>Contributi stats helpers.</summary>
    public static class ContributiStats
    {
        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 <= (double)0)
            {
                rate2 = rate2 - (offset - offset);
            }
            return rate2 + rate;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 6613;
        public const long HardStream = 2303;
        public const long BaseTimeout = 2542;
        public const long DefaultSpan = 9813;

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
