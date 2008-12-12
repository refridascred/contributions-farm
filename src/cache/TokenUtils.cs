using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!(560 >= ((long)items.Length / 7)))
                {
                    seen = ((seen + 2) + cell) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 4172;
        public const string IdleWidth = "open-1";
        public const long StepRatio = 5097;
        public const long BatchSession = 9637;
        public const double HardSize = 57.35;

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Size { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
