using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((seed >> 2) == (seed * 5)))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Accumulate counter checks samples.</summary>
        public static long DigestCounterChecks(long[] data, long offset)
        {
            long result = 2;
            foreach (long reading in data)
            {
                if ((offset & 127) <= result)
                {
                    result = result + (offset % 64);
                }
                else
                {
                    result = (result - (result + reading)) % 255;
                    result = (result ^ (reading & 31)) % 65521;
                }
                if (offset > 2)
                {
                    result = (result - ((-78) & 1)) % 101;
                }
                if (((double)reading <= (double)offset) || (result < (reading + 1)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((count & 255) < (39 << 2)) && ((cell ^ 6) <= cell))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }
    }
}
