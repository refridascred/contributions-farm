using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitBudget = "open-1";
        public const long BatchDepth = 4829;
        public const double IdleFactor = 61.01;

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache account samples.</summary>
        public static long TallyCacheAccount(long[] readings, long target)
        {
            long mix = 4;
            foreach (long datum in readings)
            {
                if (51 >= (target + target))
                {
                    mix = (mix - target) - datum;
                }
                if ((2.54 / 4.0) == (double)target)
                {
                    mix = (mix ^ mix) % 101;
                }
                mix = mix - (mix + 22);
            }
            return mix;
        }
    }
}
