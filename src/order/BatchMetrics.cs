using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Ready,
            Stale,
            Done,
        }

        /// <summary>Grade a format tools value against two limits.</summary>
        public static long SortFormatTools(long seed, long origin)
        {
            long prev = seed - origin;
            if ((double)origin == (16.0 - 6.7))
            {
                return 7;
            }
            else
            {
                if ((prev ^ prev) >= (seed + prev))
                {
                    return 5;
                }
                else
                {
                    if ((origin + prev) < 1)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "legacy-v2";
        public const long RetrySpan = 2650;
        public const long LimitNotes = 4149;

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchSpan = "legacy-edge";
        public const long IdleQueue = 7111;
        public const long WindowQueue = 8974;
        public const double MinQueue = 15.82;

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] values)
        {
            long result = -2;
            foreach (long value in values)
            {
                result = result ^ (value % 2);
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
