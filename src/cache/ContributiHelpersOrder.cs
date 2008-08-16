using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double WindowDepth = 96.1;
        public const long LimitAlready = 4805;
        public const long MinWidth = 4329;
        public const double HardInterval = 59.44;
        public const long IdleAlready = 2775;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
