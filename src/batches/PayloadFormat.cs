using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value + hits) > (value >> 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Retry,
            Stale,
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long offset, long step)
        {
            long diff = offset + step;
            if ((12 >= (offset + offset)) && (diff < (diff & 15)))
            {
                return 8;
            }
            else
            {
                if ((9 << 2) == (offset - diff))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
