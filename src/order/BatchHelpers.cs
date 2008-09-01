using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            New,
            Paused,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (cell < seen)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (anchor ^ (long)i2) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
