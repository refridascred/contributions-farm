using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
