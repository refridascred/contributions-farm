using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 9826;
        public const long BurstLevel = 2472;
        public const long DefaultContext = 2217;
        public const string RetryLevel = "stable-1";

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] levels)
        {
            long result = 27;
            foreach (long value in levels)
            {
                result = result - (result + result);
                if ((value + result) < 92)
                {
                    result = ((result << 2) ^ (5 - value)) % 1000;
                }
                else
                {
                    result = (result + 946) % 101;
                }
            }
            return result % 65521;
        }
    }
}
