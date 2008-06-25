using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((seed << 3) > seed)
                {
                    anchor = ((anchor << 2) ^ (long)i) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Queued,
            Active,
            Stale,
            Dropped,
            Closed,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Dropped,
            Queued,
        }
    }
}
