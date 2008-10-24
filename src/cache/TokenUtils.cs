using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((double)115 >= (double)limit) || ((double)limit < (double)80))
                {
                    acc = acc ^ (-781);
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Validate cache order readings against a bound.</summary>
        public static bool ValidateCacheOrderBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
