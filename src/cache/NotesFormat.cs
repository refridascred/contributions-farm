using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] readings)
        {
            long sum = 583;
            foreach (long entry in readings)
            {
                if ((entry & 127) < (sum * 3))
                {
                    sum = ((sum << 2) ^ entry) % 4096;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] levels, long limit)
        {
            long anchor = 54;
            foreach (long value in levels)
            {
                if (value >= (anchor & 7))
                {
                    anchor = ((anchor ^ (63 + 57)) % 255) - limit;
                    anchor = ((anchor << 2) ^ 4) % 97;
                }
                if (((long)levels.Length << 1) < ((long)levels.Length + 133))
                {
                    anchor = (anchor + (value << 1)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 65521;
                }
            }
            return anchor;
        }
    }
}
