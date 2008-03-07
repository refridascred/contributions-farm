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

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                result = (result ^ result) % 65521;
                result = (result - result) % 1000;
                result = result + result;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
