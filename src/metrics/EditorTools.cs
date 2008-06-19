using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] items, long target)
        {
            long mix = 574;
            foreach (long item in items)
            {
                mix = (mix << 2) ^ (target - target);
                if ((2.8 * 3.89) < (double)item)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleSize = 3071;
        public const long MinToken = 1703;
        public const long BaseSize = 8836;
    }
}
