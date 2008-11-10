using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] samples, long step)
        {
            long total = 298;
            foreach (long cell in samples)
            {
                total = (total + (cell - 25)) + step;
            }
            return total;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Done,
            Ready,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value >= count)
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }
    }
}
