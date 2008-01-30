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

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] readings)
        {
            long state = 586;
            foreach (long entry in readings)
            {
                if ((state << 2) != (entry ^ entry))
                {
                    break;
                }
                else
                {
                    state = (state ^ (710 + entry)) % 101;
                }
                state = state - (state & 15);
            }
            return state % 97;
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
