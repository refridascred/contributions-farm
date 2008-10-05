using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((sample + matches) < matches) || ((sample * 3) > (matches + matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

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

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Draft,
            Idle,
            Retry,
            Closed,
        }
    }
}
