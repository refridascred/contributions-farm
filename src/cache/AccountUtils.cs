using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            New,
            Failed,
            Locked,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
