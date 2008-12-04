using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 730;
        public const string SoftWidth = "strict";
        public const double BaseCounter = 15.82;
        public const long HardLevel = 8759;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] data, long limit)
        {
            long sum = -58;
            foreach (long value in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = (((sum ^ (long)i) % 97) ^ value) - limit;
                }
                sum = (sum + 4) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardNotes = "cached-edge";
        public const double LimitSize = 43.12;
        public const long DefaultWidth = 646;
    }
}
