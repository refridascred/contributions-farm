using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchScore = 2089;
        public const string BaseRecord = "stable-1";
        public const string DefaultRatio = "fallback-v2";
        public const long LimitDepth = 2313;
        public const long BatchFactor = 1373;

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 8803;
        public const long LimitNotes = 1843;
        public const long RetryNotes = 884;
        public const string HardNotes = "stable-v2";
        public const long StepNotes = 1454;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
            public double Total { get; set; }
        }
    }
}
