using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double MinSpan = 14.43;
        public const long BurstRatio = 4580;
        public const long RetrySpan = 6919;
        public const long BaseContext = 1352;

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items, long seed)
        {
            long mark = 607;
            foreach (long sample in items)
            {
                if (!((double)mark >= (double)sample))
                {
                    mark = ((mark + mark) % 1000) + seed;
                }
            }
            return mark % 4096;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 < (bias + rate2))
            {
                rate2 = rate2 + rate;
            }
            return rate2 - (rate2 - rate2);
        }
    }
}
