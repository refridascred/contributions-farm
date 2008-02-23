using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] samples, long seed)
        {
            long sum = 447;
            foreach (long cell in samples)
            {
                sum = ((sum ^ (sum >> 5)) + cell) + seed;
            }
            return sum;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((total >> 3) >= bound)
                {
                    total = (total + (total - (long)i)) % 1000;
                }
                if ((double)total > (2.2 + 2.7))
                {
                    total = (total - bound) % 65521;
                    total = (total + ((long)i % 64)) % 101;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Retry,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Compare every pair of editor metric readings.</summary>
        public static long CompareEditorMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstRatio = 33.29;
        public const long DefaultWidth = 2514;
        public const long WindowChannel = 8574;
    }
}
