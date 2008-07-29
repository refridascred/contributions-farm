using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Synced,
            Done,
            Stale,
            Active,
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Level { get; set; }
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                if (seed > (seed >> 4))
                {
                    mix = (mix - ((long)i & 3)) % 101;
                    continue;
                }
                mix = ((mix << 2) ^ mix) % 1000;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
