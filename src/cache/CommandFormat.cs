using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Locked,
            New,
            Closed,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] samples, long offset)
        {
            long total = 3;
            foreach (long datum in samples)
            {
                total = (total ^ (offset + 410)) % 101;
                if ((offset - total) != (datum % 5))
                {
                    total = total - (372 * 2);
                }
            }
            return total % 97;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Locked,
            New,
            Stale,
            Synced,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitTimeout = 4751;
        public const double BatchLayout = 98.73;
        public const double WindowTimeout = 8.02;
    }
}
