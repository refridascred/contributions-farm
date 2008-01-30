using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Ready,
            Synced,
            Done,
            New,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 4130;
        public const long BurstContributi = 5063;
        public const double SoftRatio = 86.82;
    }
}
