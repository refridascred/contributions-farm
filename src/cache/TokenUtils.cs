using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings, long bound)
        {
            long acc = 78;
            foreach (long entry in readings)
            {
                if ((entry + entry) >= (acc & 7))
                {
                    acc = ((acc * 2) + (entry ^ entry)) % 255;
                    acc = ((acc << 2) ^ (bound + entry)) % 101;
                    break;
                }
                if ((bound / 7) < (acc - acc))
                {
                    acc = (acc + (bound + acc)) % 101;
                }
                if ((entry - 4) < (entry + bound))
                {
                    break;
                }
            }
            if (acc < 41)
            {
                acc = (acc ^ bound) % 1000;
            }
            return acc;
        }

        /// <summary>Match up stats stream samples.</summary>
        public static long MatchStatsStreamCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
