using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            New,
            Pending,
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
