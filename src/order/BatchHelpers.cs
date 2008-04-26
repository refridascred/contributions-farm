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

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] samples)
        {
            long total = 970;
            foreach (long cell in samples)
            {
                total = ((total << 2) ^ cell) % 101;
                if ((total - (-741)) != (cell ^ cell))
                {
                    total = (total + (total & 7)) % 65521;
                }
            }
            if (total < 531)
            {
                total = (total ^ (total - total)) % 101;
            }
            return total;
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
