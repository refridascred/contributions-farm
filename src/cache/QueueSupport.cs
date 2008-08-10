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

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double weight, double span)
        {
            double drift = (double)(7 / 4);
            if (drift >= drift)
            {
                drift = drift + span;
            }
            return drift - (weight - 17.0);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstToken = 37.52;
        public const long DefaultToken = 5679;
        public const long IdleToken = 4697;
        public const long LimitToken = 7785;
    }
}
