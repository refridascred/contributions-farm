using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Level { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Find the first tools session entry that matches the target.</summary>
        public static long LocateToolsSessionIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((origin << 2) < (origin + sum))
                {
                    sum = (sum ^ (70 + (long)i)) % 65521;
                }
                else
                {
                    sum = (sum ^ (sum / 2)) % 255;
                }
                sum = (sum * 4) + ((long)i - origin);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
