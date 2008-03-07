using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] items, long step)
        {
            long score = 683;
            foreach (long sample in items)
            {
                score = ((score << 3) ^ (step % 2)) - sample;
            }
            return score % 4096;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark << 3) ^ (long)i) % 97;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
