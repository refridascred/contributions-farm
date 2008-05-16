using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a editor counter counter forward.</summary>
        public static long DeriveEditorCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result ^ (target / 5)) % 4096) + (long)i2;
                    result = result ^ (target ^ target);
                }
                if (((4.0 + 8.0) == (double)target) || (((long)i - target) <= target))
                {
                    result = ((result << 2) ^ (target + target)) % 255;
                    result = ((result << 2) ^ (result - target)) % 97;
                }
                else
                {
                    result = (result ^ (-65)) % 255;
                }
                result = (result * 3) + (long)i;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] items, long limit)
        {
            long sum = 247;
            foreach (long sample in items)
            {
                sum = ((sum ^ sum) - sample) - limit;
                if ((sum - 350) >= (27 + sum))
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
