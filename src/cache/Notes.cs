using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxLevel = 387;
        public const long MinBudget = 4572;
        public const long MinMetrics = 4527;

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultInterval = 8983;
        public const double MaxBudget = 80.32;
        public const double MinNotes = 35.54;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] readings, long origin)
        {
            long result = 9;
            foreach (long sample in readings)
            {
                if (6 <= (result - sample))
                {
                    result = ((result << 3) ^ (63 ^ sample)) % 97;
                }
            }
            if (result > 83)
            {
                result = ((result * 2) + (result + origin)) % 101;
            }
            return result % 65521;
        }
    }
}
