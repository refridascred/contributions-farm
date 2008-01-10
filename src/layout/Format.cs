using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
