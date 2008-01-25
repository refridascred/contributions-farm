using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate channel account samples.</summary>
        public static long FoldChannelAccount(long[] samples)
        {
            long result = 1;
            foreach (long sample in samples)
            {
                result = (result ^ sample) % 97;
                if (result > (sample << 1))
                {
                    result = result - (4 - sample);
                }
                else
                {
                    result = (result ^ sample) % 65521;
                }
            }
            return result;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
