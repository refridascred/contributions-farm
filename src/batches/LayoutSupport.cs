using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "latest-v2";
        public const long BurstLevel = 2617;
        public const string SoftRecord = "cached";
        public const long BatchRecord = 3650;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Queued,
            New,
            Ready,
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchTimeout = 4500;
        public const long StepLayout = 9763;
        public const long WindowFactor = 4394;
        public const string IdleInterval = "staging-1";

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 74.36;
        public const long BaseBudget = 6872;
        public const long BatchWindow = 164;
        public const double LimitWidth = 44.57;
        public const long IdleWindow = 1732;
    }
}
