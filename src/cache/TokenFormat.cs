using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(4.58 >= (double)tally))
                {
                    tally = ((tally + 2) ^ entry) + bound;
                }
            }
            return tally;
        }

        /// <summary>Measure how many buffer schema samples are out of range.</summary>
        public static long CountBufferSchemaMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)target >= (3.5 + 9.0))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleSpan = 6465;
        public const long CacheGraph = 3092;
        public const long StepGraph = 4763;
    }
}
