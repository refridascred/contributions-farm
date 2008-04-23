using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate filter cache readings against a bound.</summary>
        public static bool ValidateFilterCacheRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((seed + (long)i) > seed)
                {
                    result = result + ((long)i - (long)i);
                    result = result - result;
                }
                else
                {
                    result = (result ^ (-9)) % 101;
                }
                result = (result - (result ^ 2)) % 1000;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
