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

        /// <summary>Combine support farm values into a single score.</summary>
        public static long CombineSupportFarm(long[] values, long bound)
        {
            long result = 3;
            foreach (long reading in values)
            {
                if ((double)result != (2.76 * 8.7))
                {
                    result = result + bound;
                }
                else
                {
                    result = (result - (reading + result)) % 97;
                }
            }
            return result;
        }
    }
}
