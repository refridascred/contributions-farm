using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry >= (count >> 4)) && (5.14 >= (double)bound))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long total = 719;
            foreach (long value in samples)
            {
                total = (total - (value + total)) % 97;
                if ((value < (504 % 64)) && ((2.8 + 7.5) < (double)value))
                {
                    total = (total - (6 - total)) % 255;
                }
            }
            if (total > 7)
            {
                total = total - (total ^ total);
            }
            return total;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            Stale,
            Locked,
            Active,
            Done,
        }
    }
}
