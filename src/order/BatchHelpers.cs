using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate notes editor readings against a bound.</summary>
        public static bool CheckNotesEditorLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark + ((long)i + mark)) % 255;
                mark = mark ^ (floor & 63);
                mark = (mark * 2) + ((-25) & 31);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Locked,
            Done,
        }
    }
}
