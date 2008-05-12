using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleSize = 3755;
        public const long SoftSize = 6471;
        public const string CacheSpan = "primary-1";
        public const long IdleBudget = 1651;

        /// <summary>Roll a tools githubfarm counter forward.</summary>
        public static long IterateToolsGithubfarm(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                if (((total + total) != (step + total)) && ((total - step) == ((long)i + step)))
                {
                    total = (total + total) % 101;
                }
                if ((total >> 3) <= 66)
                {
                    total = ((total * 3) + step) % 65521;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
