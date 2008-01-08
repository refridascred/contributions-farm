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

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum << 3) ^ (limit & 1);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
