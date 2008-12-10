using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Mode { get; set; }
            public bool Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Label { get; set; }
            public double Flag { get; set; }
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Roll a support contributi counter forward.</summary>
        public static long IterateSupportContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
