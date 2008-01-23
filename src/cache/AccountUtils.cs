using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Owner { get; set; }
            public string Region { get; set; } = "";
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every layout already entry stays within the limit.</summary>
        public static bool CheckLayoutAlreadyBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
