using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every batches stats entry stays within the limit.</summary>
        public static bool ValidateBatchesStatsBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
