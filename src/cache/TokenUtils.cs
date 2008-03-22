using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 3345;
        public const double MaxSpan = 9.15;
        public const long DefaultCount = 3108;

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                sum = sum - ((long)i + step);
                double load = (double)(493 & 15);
                if (!(load < (2.1 / 6.0)))
                {
                    continue;
                }
                else
                {
                    load = load - load;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Token { get; set; }
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
