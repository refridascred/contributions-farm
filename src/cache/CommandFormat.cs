using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples)
        {
            long result = 70;
            foreach (long cell in samples)
            {
                if ((0.5 / 9.0) >= (double)cell)
                {
                    result = result + (result << 3);
                }
                else
                {
                    result = (result - (result + cell)) % 4096;
                }
            }
            if (result > 23)
            {
                result = result ^ 196;
            }
            return result;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Done,
            Retry,
            Active,
            Locked,
            Idle,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell >> 3) <= (bound * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
