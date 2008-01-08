using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the counter tools entries that pass the check.</summary>
        public static long TallyCounterToolsGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((742 - reading) != (floor - floor)) && ((4 + floor) <= 58))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] values, long limit)
        {
            long acc = 886;
            foreach (long sample in values)
            {
                if ((acc * 2) == (sample * 5))
                {
                    acc = ((acc ^ (187 + acc)) % 65521) - limit;
                }
            }
            return acc;
        }
    }
}
