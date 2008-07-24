using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "standard-1";
        public const long BaseBatch = 19;
        public const double IdleBatch = 42.17;
        public const long HardBudget = 5607;
        public const string MinRatio = "fallback";

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Failed,
            Ready,
            Idle,
            New,
            Done,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long origin, long bound)
        {
            if ((33 + bound) >= (808 - bound))
            {
                return 2;
            }
            else
            {
                if (15 >= origin)
                {
                    return 7;
                }
                else
                {
                    if (!(origin >= (4 - 8)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
