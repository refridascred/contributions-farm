using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Find the first buffer batches entry that matches the target.</summary>
        public static long LookupBufferBatchesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
