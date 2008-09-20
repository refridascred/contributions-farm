using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Label { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
